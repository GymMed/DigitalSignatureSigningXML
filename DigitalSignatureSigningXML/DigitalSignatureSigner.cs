using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Security;
using Microsoft.Xades;
using FirmaXadesNetCore;
using FirmaXadesNetCore.Crypto;
using FirmaXadesNetCore.Signature.Parameters;
using FirmaXadesNetCoreUpdated.Signature;
using FirmaXadesNetCoreUpdated;

namespace DigitalSignatureSigningXML
{
    public sealed class DigitalSignatureSigner
    {
        private static DigitalSignatureSigner instance = null;
        private static X509Certificate2 usingCertificate;
        private static string sourcePath, destinationPath;

        private DigitalSignatureSigner()
        {
        }

        public static DigitalSignatureSigner Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DigitalSignatureSigner();
                }
                return instance;
            }
        }

        public static string SourcePath { set => sourcePath = value; }
        public static string DestinationPath { set => destinationPath = value; }

        public static SuccessReport DigitallySignXMLInXades()
        {
            SuccessReport signingReport = SuccessReport.GetReport();

            try
            {
                MemoryStream input = new MemoryStream(File.ReadAllBytes(sourcePath));

                SignatureParameters parameters = new SignatureParameters();
                parameters.SignatureMethod = SignatureMethod.RSAwithSHA256;
                parameters.SigningDate = DateTime.Now;
                parameters.SignaturePackaging = SignaturePackaging.ENVELOPED;

                if (usingCertificate.PrivateKey is RSACryptoServiceProvider rsa)
                {
                    SecureString securePwd = new SecureString();
                    //prieš priskiriant slaptažodį galima patikrinti sertifikato informaciją
                    //X509Certificate2.Subject, o jei turi pora raktų X509Certificate2.Publickey
                    foreach (char c in "my password")
                    {
                        securePwd.AppendChar(c);
                    }

                    CspParameters cspParams = new CspParameters(1, rsa.CspKeyContainerInfo.ProviderName,
                        rsa.CspKeyContainerInfo.UniqueKeyContainerName)
                    {
                        KeyPassword = securePwd,
                        Flags = CspProviderFlags.NoPrompt
                    };

                    RSACryptoServiceProvider rsaCsp = new RSACryptoServiceProvider(cspParams);

                    FirmaXadesNetCoreUpdated.Crypto.SignerUpdated signer = new FirmaXadesNetCoreUpdated.Crypto.SignerUpdated(usingCertificate);
                    signer.SigningKey = rsaCsp;
                    parameters.Signer = signer;
                }
                else
                    parameters.Signer = new Signer(usingCertificate);

                XadesServiceManager xadesService = new XadesServiceManager();

                SignatureDocument signatureDocument = new SignatureDocument();

                using (FileStream fs = new FileStream(sourcePath, FileMode.Open))
                {
                    signatureDocument = xadesService.Sign(fs, parameters);
                }

                // Save the signed XML document to a file
                using (FileStream output = new FileStream(destinationPath, FileMode.Create))
                {
                    signatureDocument.Save(output);
                }

                signingReport.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                signingReport.IsSuccessful = false;

                //vienas paprastasm sertifikatui, o kitas el. parasui
                if (ex.Message == "The specified network password is not correct.\r\n" || ex.Message == "The supplied PIN is incorrect.\r\n")
                    signingReport.Message = "Nurodytas sertifikato slaptažodis neteisingas!";
                else
                    signingReport.Message = ex.Message;
            }

            return signingReport;
        }

        public static SuccessReport DigitallySignXMLDocument()
        {
            SuccessReport signingReport = SuccessReport.GetReport();

            try
            {
                //File.Copy(sourcePath, destinationPath, true);

                XmlDocument document = new XmlDocument();
                document.PreserveWhitespace = true;
                document.Load(sourcePath);

                if (usingCertificate == null)
                {
                    signingReport.Message = "El. parašu pasirašyti nepavyko, nes nepasirinktas sertifikatas!";
                    return signingReport;
                }

                //XadesSignedXml vietoje SignedXml
                //XadesSignedXml neegzistuoja standard .NET Framework bibliotekose
                //todėl įrašom Microsoft.Xades NuGet paketą, kuris naudoja
                //Xades standartus sukurti el. parašą
                XadesSignedXml signedXml = new XadesSignedXml(document);

                signedXml.SigningKey = usingCertificate.PrivateKey;

                //naudojamas tuscias string, kad butu pasirasytas
                //visas dokumentas, o ne tik viena jo dalis
                Reference reference = new Reference("");
                reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
                signedXml.AddReference(reference);

                KeyInfo keyInfo = new KeyInfo();
                keyInfo.AddClause(new KeyInfoX509Data(usingCertificate));

                if (usingCertificate.PrivateKey is RSACryptoServiceProvider rsa)
                {
                    SecureString securePwd = new SecureString();
                    //prieš priskiriant slaptažodį galima patikrinti sertifikato informaciją
                    //X509Certificate2.Subject, o jei turi pora raktų X509Certificate2.Publickey
                    foreach (char c in "your password")
                    {
                        securePwd.AppendChar(c);
                    }

                    CspParameters cspParams = new CspParameters(1, rsa.CspKeyContainerInfo.ProviderName,
                        rsa.CspKeyContainerInfo.UniqueKeyContainerName)
                    {
                        KeyPassword = securePwd,
                        Flags = CspProviderFlags.NoPrompt
                    };

                    RSACryptoServiceProvider rsaCsp = new RSACryptoServiceProvider(cspParams);

                    signedXml.SigningKey = rsaCsp;
                }
                else
                {
                    signedXml.KeyInfo = keyInfo;
                }

                signedXml.ComputeSignature();

                XmlElement signatureElement = signedXml.GetXml();
                //jei parašų yra daugiau kiekvienas iš jų turi turėti orginalų id
                string signatureId = "signature-" + Guid.NewGuid().ToString();
                signatureElement.SetAttribute("Id", signatureId);

                document.DocumentElement.AppendChild(signatureElement);

                document.Save(destinationPath);

                signingReport.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                signingReport.IsSuccessful = false;

                //vienas paprastasm sertifiaktui, o kitas el. parasui
                if (ex.Message == "The specified network password is not correct.\r\n" || ex.Message == "The supplied PIN is incorrect.\r\n")
                    signingReport.Message = "Nurodytas sertifikato slaptažodis neteisingas!";
                else
                    signingReport.Message = ex.Message;
            }

            return signingReport;
        }

        public static SuccessReport VerifyDigitalSignatureInXMLXades()
        {
            SuccessReport report = new SuccessReport();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = true;
            xmlDoc.Load(sourcePath);

            FirmaXadesNetCoreUpdated.Signature.SignatureDocument signatureDocument = new SignatureDocument();
            signatureDocument.Document = xmlDoc;
            signatureDocument.XadesSignature = new Microsoft.XadesUpdated.XadesSignedXmlUpdated(xmlDoc);

            XadesServiceManager xadesService = new XadesServiceManager();

            try
            {
                FirmaXadesNetCoreUpdated.Validation.ValidationResult validationResult = xadesService.Validate(signatureDocument);

                if (validationResult.IsValid)
                {
                    report.Message = "Aptiktas sertifikato el.parašas!";
                    report.IsSuccessful = true;
                }
                else
                    report.Message = "Dokumentas nepasirašytas pasirinkto sertifikato el.parašu!";
            }
            catch(Exception ex)
            {
                report.Message = ex.Message;
            }

            return report;
        }

        public static SuccessReport VerifyDigitalSignatureInXMLDocument()
        {
            SuccessReport report = new SuccessReport();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = true;
            xmlDoc.Load(sourcePath);

            SignedXml signedXml = new SignedXml(xmlDoc);
            XmlNodeList signatureNodes = xmlDoc.GetElementsByTagName("Signature");

            foreach (XmlElement signatureNode in signatureNodes)
            {
                signedXml.LoadXml(signatureNode);

                RSACryptoServiceProvider rsaPublicKey = (RSACryptoServiceProvider)usingCertificate.PublicKey.Key;

                if (signedXml.CheckSignature(rsaPublicKey))
                {
                    report.Message = "Aptiktas sertifikato el.parašas!";
                    report.IsSuccessful = true;
                    break;
                }
            }

            if(!report.IsSuccessful)
                report.Message = "Dokumentas nepasirašytas pasirinkto sertifikato el.parašu!";

            return report;
        }

        public static SuccessReport SelectCertificateFromStore(string subjectName = null)
        {
            SuccessReport report = SuccessReport.GetReport();
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);

            X509Certificate2Collection collection;
            if (subjectName != null)
            {
                collection = store.Certificates.Find(X509FindType.FindBySubjectName, subjectName, false);
            }
            else
            {
                collection = store.Certificates;
            }

            if (collection.Count > 0)
            {
                X509Certificate2Collection selectedCerts = X509Certificate2UI.SelectFromCollection(collection, "Pasirinkite sertifikatą", "Pasirinkite sertifikatą elektroninio parašo pasirašymui!", X509SelectionFlag.SingleSelection);
                if (selectedCerts.Count > 0)
                {
                    usingCertificate = selectedCerts[0];

                    report.IsSuccessful = true;
                    report.Message = "Sėkmingai parinktas sertifikatas. Sertifikato savininkas: " + GetCommonNameFromCertificateSubjectName(usingCertificate.SubjectName.Name);
                }
                else
                {
                    report.Message = "Nepasirinktas sertifikatas!";
                }
            }
            else
            {
                report.Message = "Kompiuteryje nerasta sertifikatų!";
            }

            store.Close();

            return report;
        }

        public static SuccessReport CreateAndSetCertificate(string certificatePath, string certificatePassword)
        {
            SuccessReport report = SuccessReport.GetReport();

            if (certificatePath == null)
            {
                report.Message = "Nenustatytas sertifikato lokacijos laukelis!";
                return report;
            }

            if (!Path.GetExtension(certificatePath).Equals(".pfx", StringComparison.OrdinalIgnoreCase))
            {
                report.Message = "Sertifikato dokumentas turi būti .pfx formato!";
                return report;
            }

            if (certificatePassword == null)
            {
                report.Message = "Įveskite sertifikato slaptažodį!";
                return report;
            }

            try
            {
                //Svarbu, kad dokumentas butu .pfx formato is 
                //kriptografines usb laikmenos isimtas .cer netinka,
                //nes .cer dokumentai turi tik public(viesa) rakta
                //skirta patvirtinti el. parasa, o .pfx turi ir
                //private(privatu) ir public rakta, todel svarbu
                //X509Certificate2 klase kurti su .pfx dokumentu
                //arba teks nusirodyti private rakta atskirai
                usingCertificate = new X509Certificate2(certificatePath, certificatePassword,
                    X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.EphemeralKeySet | X509KeyStorageFlags.Exportable);

                report.Message = "Sėkmingai parinktas sertifikatas. Sertifikato savininkas: " + GetCommonNameFromCertificateSubjectName(usingCertificate.Subject);
                report.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                report.IsSuccessful = false;

                if (ex.Message.Equals("The specified network password is not correct.\r\n"))
                    report.Message = "Nurodytas sertifikato slaptažodis neteisingas!";
                else
                    report.Message = ex.Message;
            }

            return report;
        }

        //Naudojama tik validuoti el. parašą, nes pasirašymui riekalingas
        //privatus raktas, kuris gaunamas tik su slaptažodžiu!
        public static SuccessReport CreateAndSetCertificate(string certificatePath)
        {
            SuccessReport report = SuccessReport.GetReport();

            if (certificatePath == null)
            {
                report.Message = "Nenustatytas sertifikato lokacijos laukelis!";
                return report;
            }

            if (Path.GetExtension(certificatePath).Equals(".cer", StringComparison.OrdinalIgnoreCase))
            {
                report.Message = "Sertifikato dokumentas turi būti .cer formato!";
                return report;
            }

            try
            {
                //Svarbu, kad dokumentas butu .pfx formato is 
                //kriptografines usb laikmenos isimtas .cer netinka,
                //nes .cer dokumentai turi tik public(viesa) rakta
                //skirta patvirtinti el. parasa, o .pfx turi ir
                //private(privatu) ir public rakta, todel svarbu
                //X509Certificate2 klase kurti su .pfx dokumentu
                //arba teks nusirodyti private rakta atskirai
                usingCertificate = new X509Certificate2(certificatePath);

                report.Message = "Sėkmingai parinktas sertifikatas. Sertifikato savininkas: " + GetCommonNameFromCertificateSubjectName(usingCertificate.Subject);
                report.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                report.IsSuccessful = false;
                report.Message = ex.Message;
            }

            return report;
        }

        private static string GetCommonNameFromCertificateSubjectName(string subjectName)
        {
            string cnPattern = @"CN=(?<cn>[^,]+)";
            Match cnMatch = Regex.Match(subjectName, cnPattern);

            return cnMatch.Groups["cn"].Value;
        }
    }
}
