using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Globalization;
using CloudPay.Util;

namespace CloudPay {

    namespace Data {

        public class StoredProcedure {

            private string _name;
            private ArrayList _parameters;

            public StoredProcedure(string spName) {
                if (spName == null) {
                    throw new ArgumentNullException("spName");
                }

                if (spName == string.Empty) {
                    throw new ArgumentException("\"spName\" cannot be an empty string", "spName");
                }

                _name = spName;
                _parameters = new ArrayList();
            }

            public void AddParameter(string paramName, object paramValue, SqlDbType paramType) {
                SqlParameter sqlParameter;

                if (paramName == null) {
                    throw new ArgumentNullException("paramName");
                }

                if (paramName == string.Empty) {
                    throw new ArgumentException("\"paramName\" cannot be an empty string", "paramName");
                }

                if (paramValue == null) {
                    throw new ArgumentNullException("paramValue");
                }

                sqlParameter = new SqlParameter("@" + paramName, paramType);
                sqlParameter.Value = paramValue;
                _parameters.Add(sqlParameter);
            }

            public void AddParameter(string paramName, object paramValue, SqlDbType paramType, int paramSize) {
                SqlParameter sqlParameter;

                if (paramName == null) {
                    throw new ArgumentNullException("paramName");
                }

                if (paramName == string.Empty) {
                    throw new ArgumentException("\"paramName\" cannot be an empty string", "paramName");
                }

                if (paramValue == null) {
                    throw new ArgumentNullException("paramValue");
                }

                if (paramSize < 1) {
                    throw new ArgumentException("\"paramSize\" cannot be zero or negative number", "paramSize");
                }

                sqlParameter = new SqlParameter("@" + paramName, paramType, paramSize);
                sqlParameter.Value = paramValue;
                _parameters.Add(sqlParameter);
            }

            public DataTable Execute() {
                DataTable table;
                DataSet ds;
                SqlDataAdapter da;
                string cnnString;

                ds = new DataSet();
                cnnString = WebConfig.GetCnnString("CP_cnnString");

                using (SqlConnection cnn = new SqlConnection(cnnString)) {
                    using (SqlCommand cmd = new SqlCommand()) {
                        cmd.Connection = cnn;
                        cmd.CommandText = _name;
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        foreach (SqlParameter parameter in _parameters) {
                            cmd.Parameters.Add(parameter);
                        }

                        da = new SqlDataAdapter(cmd);
                        da.Fill(ds, "table");
                        table = ds.Tables[0];
                    }
                }

                return table;
            }

            public DataTable Execute(string tableName) {
                DataTable table;
                DataSet ds;
                SqlDataAdapter da;
                string cnnString;

                if (tableName == null) {
                    throw new ArgumentNullException("tableName");
                }

                if (tableName == string.Empty) {
                    throw new ArgumentException("\"tableName\" cannot be an empty string", "tableName");
                }

                ds = new DataSet();
                cnnString = WebConfig.GetCnnString("CP_cnnString");

                using (SqlConnection cnn = new SqlConnection(cnnString)) {
                    using (SqlCommand cmd = new SqlCommand()) {
                        cmd.Connection = cnn;
                        cmd.CommandText = _name;
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (SqlParameter parameter in _parameters) {
                            cmd.Parameters.Add(parameter);
                        }

                        da = new SqlDataAdapter(cmd);
                        da.Fill(ds, tableName);
                        table = ds.Tables[tableName];
                    }
                }

                return table;
            }

            public int ExecuteNonQuery() {
                string cnnString;
                int rowsAffected;

                cnnString = WebConfig.GetCnnString("CP_cnnString");

                using (SqlConnection cnn = new SqlConnection(cnnString)) {
                    using (SqlCommand cmd = new SqlCommand()) {
                        cmd.Connection = cnn;
                        cmd.CommandText = _name;
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (SqlParameter parameter in _parameters) {
                            cmd.Parameters.Add(parameter);
                        }

                        cnn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }

                return rowsAffected;
            }

            public int GetIntegerValue() {
                string cnnString;
                object value;
                int intValue;

                cnnString = WebConfig.GetCnnString("CP_cnnString");

                using (SqlConnection cnn = new SqlConnection(cnnString)) {
                    using (SqlCommand cmd = new SqlCommand()) {
                        cmd.Connection = cnn;
                        cmd.CommandText = _name;
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (SqlParameter parameter in _parameters) {
                            cmd.Parameters.Add(parameter);
                        }

                        cnn.Open();
                        value = cmd.ExecuteScalar();
                        cnn.Close();
                    }
                }

                intValue = int.Parse(value.ToString(), CultureInfo.InvariantCulture);

                return intValue;
            }

            public bool GetBooleanValue() {
                string cnnString;
                object value;
                bool booleanValue;

                cnnString = WebConfig.GetCnnString("CP_cnnString");

                using (SqlConnection cnn = new SqlConnection(cnnString)) {
                    using (SqlCommand cmd = new SqlCommand()) {
                        cmd.Connection = cnn;
                        cmd.CommandText = _name;
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (SqlParameter parameter in _parameters) {
                            cmd.Parameters.Add(parameter);
                        }

                        cnn.Open();
                        value = cmd.ExecuteScalar();
                        cnn.Close();
                    }
                }

                booleanValue = Convert.ToBoolean(value, CultureInfo.InvariantCulture);

                return booleanValue;
            }

            public string GetStringValue() {
                string cnnString;
                object value;
                string stringValue;

                cnnString = WebConfig.GetCnnString("CP_cnnString");

                using (SqlConnection cnn = new SqlConnection(cnnString)) {
                    using (SqlCommand cmd = new SqlCommand()) {
                        cmd.Connection = cnn;
                        cmd.CommandText = _name;
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (SqlParameter parameter in _parameters) {
                            cmd.Parameters.Add(parameter);
                        }

                        cnn.Open();
                        value = cmd.ExecuteScalar();
                        cnn.Close();
                    }
                }

                stringValue = value.ToString();

                return stringValue;
            }

            public double GetDoubleValue() {
                string cnnString;
                object value;
                double doubleValue;

                cnnString = WebConfig.GetCnnString("CP_cnnString");

                using (SqlConnection cnn = new SqlConnection(cnnString)) {
                    using (SqlCommand cmd = new SqlCommand()) {
                        cmd.Connection = cnn;
                        cmd.CommandText = _name;
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (SqlParameter parameter in _parameters) {
                            cmd.Parameters.Add(parameter);
                        }

                        cnn.Open();
                        value = cmd.ExecuteScalar();
                        cnn.Close();
                    }
                }

                doubleValue = double.Parse(value.ToString(), CultureInfo.InvariantCulture);

                return doubleValue;
            }

            public float GetFloatValue() {
                string cnnString;
                object value;
                float floatValue;

                cnnString = WebConfig.GetCnnString("CP_cnnString");

                using (SqlConnection cnn = new SqlConnection(cnnString)) {
                    using (SqlCommand cmd = new SqlCommand()) {
                        cmd.Connection = cnn;
                        cmd.CommandText = _name;
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (SqlParameter parameter in _parameters) {
                            cmd.Parameters.Add(parameter);
                        }

                        cnn.Open();
                        value = cmd.ExecuteScalar();
                        cnn.Close();
                    }
                }

                floatValue = float.Parse(value.ToString(), CultureInfo.InvariantCulture);

                return floatValue;
            }
        }
    }
}