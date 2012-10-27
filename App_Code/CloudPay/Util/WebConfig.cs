using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CloudPay {

    namespace Util {

        public static class WebConfig {

            public static string GetAppParameter(string key) {
                string value;

                if (key == null) {
                    throw new ArgumentNullException("key");
                }

                if (key.Length == 0) {
                    throw new ArgumentException("\"key\" cannot be an empty string", "key");
                }

                try {
                    value = ConfigurationManager.AppSettings[key];
                }
                catch (NullReferenceException) {
                    throw new ArgumentException("'" + key + "' app parameter doesn't exist in Web.config", "key");
                }

                return value;
            }

            public static string GetCnnString(string cnnStringName) {
                string cnnString;

                if (cnnStringName == null) {
                    throw new ArgumentNullException("cnnStringName");
                }

                if (cnnStringName.Length == 0) {
                    throw new ArgumentException("\"cnnStringName\" cannot be an empty string", "cnnStringName");
                }

                try {
                    cnnString = ConfigurationManager.ConnectionStrings[cnnStringName].ConnectionString;
                }
                catch (NullReferenceException) {
                    throw new ArgumentException("'" + cnnStringName + "' connection string doesn't exist in Web.config", "cnnStringName");
                }

                return cnnString;
            }
        }
    }
}