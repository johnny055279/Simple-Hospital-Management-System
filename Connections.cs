using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManageSystem
{
    internal class Connections
    {
        internal int LogIn(string strConnect, string strCommand, string userName, string passWord)
        {
            SqlConnection sqlConnection = new SqlConnection(strConnect);
            SqlCommand sqlCommand = new SqlCommand(strCommand, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter paraUserName = new SqlParameter("@Account", SqlDbType.NVarChar, 16);
            paraUserName.Direction = ParameterDirection.Input;
            paraUserName.Value = userName;
            sqlCommand.Parameters.Add(paraUserName);

            SqlParameter paraPassword = new SqlParameter("@password", SqlDbType.VarBinary, 32);
            paraPassword.Direction = ParameterDirection.Input;
            byte[] bytePassword = Encoding.Unicode.GetBytes(passWord);
            SHA256Managed sHA256Managed = new SHA256Managed();
            paraPassword.Value = sHA256Managed.ComputeHash(bytePassword);
            sqlCommand.Parameters.Add(paraPassword);

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

        internal void SignUp(string strConnect, string strCommand, string userName, string passWord,
            string firstName, string lastName, string birthday, string sexual, string email,
            string Occupation, string department, string picture, string phyID)
        {
            SqlConnection sqlConnection = new SqlConnection(strConnect);
            SqlCommand sqlCommand = new SqlCommand(strCommand, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter paraUserName = new SqlParameter("@Username", SqlDbType.NVarChar, 16);
            paraUserName.Direction = ParameterDirection.Input;
            paraUserName.Value = userName;
            sqlCommand.Parameters.Add(paraUserName);

            SqlParameter paraPassword = new SqlParameter("@Password", SqlDbType.VarBinary);
            paraPassword.Direction = ParameterDirection.Input;
            byte[] bytePassword = Encoding.Unicode.GetBytes(passWord);
            SHA256Managed sHA256Managed = new SHA256Managed();
            paraPassword.Value = sHA256Managed.ComputeHash(bytePassword);
            sqlCommand.Parameters.Add(paraPassword);

            SqlParameter paraFirstName = new SqlParameter("@FirstName", SqlDbType.NVarChar, 16);
            paraFirstName.Direction = ParameterDirection.Input;
            paraFirstName.Value = firstName;
            sqlCommand.Parameters.Add(paraFirstName);

            SqlParameter paraLastName = new SqlParameter("@LastName", SqlDbType.NVarChar, 16);
            paraLastName.Direction = ParameterDirection.Input;
            paraLastName.Value = lastName;
            sqlCommand.Parameters.Add(paraLastName);

            SqlParameter paraBirthday = new SqlParameter("@Birthday", SqlDbType.Date);
            paraBirthday.Direction = ParameterDirection.Input;
            paraBirthday.Value = birthday;
            sqlCommand.Parameters.Add(paraBirthday);

            SqlParameter paraSexual = new SqlParameter("@Sexual", SqlDbType.NVarChar, 10);
            paraSexual.Direction = ParameterDirection.Input;
            paraSexual.Value = sexual;
            sqlCommand.Parameters.Add(paraSexual);

            SqlParameter paraEmail = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
            paraEmail.Direction = ParameterDirection.Input;
            paraEmail.Value = email;
            sqlCommand.Parameters.Add(paraEmail);

            SqlParameter paraOccupation = new SqlParameter("@Occupation", SqlDbType.NVarChar, 50);
            paraOccupation.Direction = ParameterDirection.Input;
            paraOccupation.Value = Occupation;
            sqlCommand.Parameters.Add(paraOccupation);

            SqlParameter paraDepartment = new SqlParameter("@Department", SqlDbType.NVarChar, 50);
            paraDepartment.Direction = ParameterDirection.Input;
            paraDepartment.Value = department;
            sqlCommand.Parameters.Add(paraDepartment);

            SqlParameter paraPicture = new SqlParameter("@Picture", SqlDbType.VarBinary);
            paraPicture.Direction = ParameterDirection.Input;
            FileStream fileStream = new FileStream(picture, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fileStream.Length];
            fileStream.Read(data, 0, (int)fileStream.Length);
            paraPicture.Value = data;
            sqlCommand.Parameters.Add(paraPicture);

            SqlParameter paraPhyID = new SqlParameter("@PhysicianID", SqlDbType.NVarChar, 7);
            paraPhyID.Direction = ParameterDirection.Input;
            paraPhyID.Value = phyID;
            sqlCommand.Parameters.Add(paraPhyID);

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            sqlConnection.Close();
            sqlConnection.Dispose();
            fileStream.Close();
            fileStream.Dispose();
        }
    }
}