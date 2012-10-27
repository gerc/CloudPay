using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CloudPay.Data;
using CloudPay.Security;

namespace CloudPay {

    namespace Session {

        public static class SessionManager {

            public static bool IsValidUser(string user, string pwd) {
                string md5Pwd;
                string md5DbPwd;
                StoredProcedure spPwd;
                StoredProcedure spUser;
                bool existUser;

                if (user == null) {
                    throw new ArgumentNullException("key");
                }

                if (user.Length == 0) {
                    throw new ArgumentException("\"user\" cannot be an empty string", "user");
                }

                if (pwd == null) {
                    throw new ArgumentNullException("key");
                }

                if (pwd.Length == 0) {
                    throw new ArgumentException("\"pwd\" cannot be an empty string", "pwd");
                }

                spUser = new StoredProcedure("SP_ExistUser");
                spUser.AddParameter("user", user, SqlDbType.VarChar, 30);
                existUser = spUser.GetBooleanValue();

                if (!existUser) {
                    return false;
                }

                spPwd = new StoredProcedure("SP_GetPwd");
                spPwd.AddParameter("user", user, SqlDbType.VarChar, 30);
                md5DbPwd = spPwd.GetStringValue();
                md5Pwd = Cryptography.MD5(pwd);

                if (md5Pwd == md5DbPwd) {
                    return true;
                }
                else {
                    return false;
                }
            }

            public static string GetUserName(string user) {
                string userName;
                StoredProcedure sp;

                sp = new StoredProcedure("SP_GetUserName");
                sp.AddParameter("app_user", user, SqlDbType.VarChar, 30);
                userName = sp.GetStringValue();

                return userName;
            }
        }
    }
}