using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HospitalManageSystem
{
    internal class Check
    {
        internal enum Strength
        {
            Invalid = 0, //無效密碼
            Weak = 1, //低強度密碼
            Normal = 2, //中強度密碼
            Strong = 3 //高強度密碼
        };

        internal int AccountExistCheck(string strConnect, string strCommand, string userName)
        {
            SqlConnection sqlConnection = new SqlConnection(strConnect);
            SqlCommand sqlCommand = new SqlCommand(strCommand, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter paraUserName = new SqlParameter("@Account", SqlDbType.NVarChar, 16);
            paraUserName.Direction = ParameterDirection.Input;
            paraUserName.Value = userName;
            sqlCommand.Parameters.Add(paraUserName);

            SqlParameter returnValue = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
            returnValue.Direction = ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(returnValue);

            sqlConnection.Open();

            sqlCommand.ExecuteReader();

            int i = Convert.ToInt32(sqlCommand.Parameters["@RETURN_VALUE"].Value);
            sqlCommand.Dispose();
            sqlConnection.Close();
            sqlConnection.Dispose();
            return i;
        }

        internal bool UserSignUpCheck(List<string> list)
        {
            foreach (string content in list)
            {
                if (content == "")
                {
                    return false;
                }
            }
            return true;
        }

        internal static Strength PasswordStrength(string password)
        {
            //空字串強度值為0
            if (password == "")
            {
                return Strength.Invalid;
            }
            //字元統計
            int iNum = 0, iLtt = 0, iSym = 0;
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9') iNum++;
                else if (c >= 'a' && c <= 'z') iLtt++;
                else if (c >= 'A' && c <= 'Z') iLtt++;
                else iSym++;
            }
            if (iLtt == 0 && iSym == 0) return Strength.Weak; //純數字密碼
            if (iNum == 0 && iLtt == 0) return Strength.Weak; //純符號密碼
            if (iNum == 0 && iSym == 0) return Strength.Weak; //純字母密碼
            if (password.Length <= 6) return Strength.Weak; //長度不大於6的密碼
            if (iLtt == 0) return Strength.Normal; //數字和符號構成的密碼
            if (iSym == 0) return Strength.Normal; //數字和字母構成的密碼
            if (iNum == 0) return Strength.Normal; //字母和符號構成的密碼
            if (password.Length <= 10) return Strength.Normal; //長度不大於10的密碼
            return Strength.Strong; //由數字、字母、符號構成的密碼
        }

        internal static bool HasChinese(string inputData)
        {
            Regex RegCHZN = new Regex("[\u4e00-\u9fa5]");
            Match m = RegCHZN.Match(inputData);
            return m.Success;
        }

        internal static bool IsValidEMailAddress(string email)
        {
            return Regex.IsMatch(email, @"^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$");
        }
    }
}