using System;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace CloudPay {

    namespace Security {

        public static class Cryptography {

            public static string MD5(string text) {
                string md5Hash;
                StringBuilder sb;
                byte[] textBytes;
                byte[] encodedBytes;
                MD5CryptoServiceProvider md5Provider;

                if (text == null) {
                    throw new ArgumentNullException("text");
                }

                sb = new StringBuilder();
                md5Provider = new MD5CryptoServiceProvider();
                textBytes = ASCIIEncoding.Default.GetBytes(text);
                encodedBytes = md5Provider.ComputeHash(textBytes);

                for (int i = 0; i < encodedBytes.Length; i++) {
                    sb.AppendFormat("{0:x2}", encodedBytes[i]);
                }

                md5Hash = sb.ToString();

                return md5Hash;
            }
        }
    }
}