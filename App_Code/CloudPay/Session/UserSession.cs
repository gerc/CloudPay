using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudPay {

    namespace Session {

        public class UserSession {
            public string AppName {
                get;
                set;
            }

            public string Name {
                get;
                set;
            }

            public UserSession(string appName, string name) {
                AppName = appName;
                Name = name;
	        }
        }
    }
}