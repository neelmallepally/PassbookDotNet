using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Pkcs;
using Newtonsoft.Json;

namespace GeneratePass
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatePassJsonFile();

            CreatePassFolder();

            CreateManifestFile();

            SignManifestFile();

            CompressPass();

            Console.ReadLine();

        }

        private static void CreatePassFolder()
        {
            
        }

        private static void CreateManifestFile()
        {

            //read all files from passDirectory
            var passDirectory = @"C:\Users\Neel\Documents\Passbook\TesCoupon";
            var dir = new DirectoryInfo(passDirectory);
           
            //read all files from dir and create a dictionary with key as the name of the file and
            // value as hash value of content of file

            var fileHashDic = new Dictionary<string, string>();
            foreach (FileInfo fi in dir.GetFiles())
            {
                fileHashDic.Add(fi.Name, GetHashOfFile(fi));
            }

            var json = JsonConvert.SerializeObject(fileHashDic);

            var manifestFile = dir.FullName + "\\manifest.json";
            if (File.Exists(manifestFile))
                File.Delete(manifestFile);
           
            using (StreamWriter sw = File.CreateText(manifestFile))
            {
                sw.WriteLine(json);
            }
           
        }

        private static string GetHashOfFile(FileInfo fi)
        {
            using(FileStream fs = new FileStream(fi.FullName, FileMode.Open))
            {
                using(SHA1Managed sha1 = new SHA1Managed())
                {
                    byte[] hash= sha1.ComputeHash(fs);
                    StringBuilder formatted = new StringBuilder(hash.Length);
                    foreach(byte b in hash)
                    {
                        formatted.AppendFormat("{0:X2}", b);
                    }
                    return formatted.ToString();
                }
            }
        }

        private static void SignManifestFile()
        {

            //Get certificates
            var certificatePath = @"C:\Users\Neel\Documents\Passbook\Certificates\pass.cer";
            X509Certificate2 cert = new X509Certificate2(certificatePath);
            
            RSACryptoServiceProvider rsaCryptoServiceProvider = (RSACryptoServiceProvider)cert.PrivateKey;

            var passDirectory = @"C:\Users\Neel\Documents\Passbook\TesCoupon";
            var dir = new DirectoryInfo(passDirectory);

            var manifestFile = dir.FullName + "\\manifest.json";

            var dataTobeSigned = File.ReadAllBytes(manifestFile);
            var signedData = rsaCryptoServiceProvider.SignData(dataTobeSigned, new SHA1CryptoServiceProvider());

            var signature = dir.FullName + "\\signature";
            if (File.Exists(signature))
                File.Delete(signature);

            File.CreateText(signature);
            File.WriteAllBytes(signature, signedData);
        }

      

        private static void CompressPass()
        {
            
        }

        private static void CreatePassJsonFile()
        {
        }
    }


}
