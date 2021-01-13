using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RestAPIDemoServer
{
    class SecurityFunction
    {   
        private string CalculateMD5Hash(string input)
        {

            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)

            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }


        public bool UserLogin(string id, string password)
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.StaffTbl WHERE id = @id and passwordHash=@passwordHash");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@passwordHash", CalculateMD5Hash(password));
            DataTable dt = sql.executeSQLQuery(cmd);
            if(dt.Rows.Count == 1)
            {
                //Get User Login Data and Cache for further use if needed 
                GlobalVar.currentUser.account = dt.Rows[0]["account"].ToString();
                GlobalVar.currentUser.gender = dt.Rows[0]["gender"].ToString();
                GlobalVar.currentUser.id = int.Parse(dt.Rows[0]["id"].ToString());
                GlobalVar.currentUser.name = dt.Rows[0]["name"].ToString();
                GlobalVar.currentUser.passwordHash = dt.Rows[0]["passwordHash"].ToString();
                GlobalVar.currentUser.permission = int.Parse(dt.Rows[0]["permission"].ToString());
                GlobalVar.currentUser.remark = dt.Rows[0]["remark"].ToString();
                return true;
            }
            return false;
        }

        public bool ChangePassword(int id, string newPassword)
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.StaffTbl SET passwordHash=@passwordHash WHERE id = @id");
            cmd.Parameters.AddWithValue("@passwordHash", CalculateMD5Hash(newPassword));
            cmd.Parameters.AddWithValue("@id", id);
            int result = sql.executeSQL(cmd);
            if (result == 1)
            {
                return true;
            }
            return false;
        }

        public bool NewUser(GlobalVar.StaffData newUser, string newPassword)
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.StaffTbl(account,passwordHash,name,gender,permission,remark) VALUES (@account,@passwordHash,@name,@gender,@permission,@remark)");
            cmd.Parameters.AddWithValue("@account", newUser.account);
            cmd.Parameters.AddWithValue("@passwordHash", CalculateMD5Hash(newPassword));
            cmd.Parameters.AddWithValue("@name", newUser.name);
            cmd.Parameters.AddWithValue("@gender", newUser.gender);
            cmd.Parameters.AddWithValue("@permission", newUser.permission);
            cmd.Parameters.AddWithValue("@remark", newUser.remark);
            int result = sql.executeSQL(cmd);
            if (result == 1)
            {
                return true;
            }
            return false;
        }

        public bool UpdataUserData(GlobalVar.StaffData newUser)
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.StaffTbl SET account=@account,name=@name,gender=@gender,permission=@permission,remark=@remark WHERE id=@id");
            cmd.Parameters.AddWithValue("@id", newUser.id);
            cmd.Parameters.AddWithValue("@account", newUser.account);
            cmd.Parameters.AddWithValue("@name", newUser.name);
            cmd.Parameters.AddWithValue("@gender", newUser.gender);
            cmd.Parameters.AddWithValue("@permission", newUser.permission);
            cmd.Parameters.AddWithValue("@remark", newUser.remark);
            int result = sql.executeSQL(cmd);
            if (result == 1)
            {
                return true;
            }
            return false;
        }
        public bool DeleteUser(GlobalVar.StaffData deleteUser)
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("DELETE FROM dbo.StaffTbl WHERE id=@id");
            cmd.Parameters.AddWithValue("@id", deleteUser.id);
            int result = sql.executeSQL(cmd);
            if (result == 1)
            {
                return true;
            }
            return false;
        }

        public bool RemoveMobileSession(int id)
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.StaffTbl SET tokenExpire=@tokenExpire WHERE id = @id");
            cmd.Parameters.AddWithValue("@tokenExpire", DateTime.Now.AddYears(-1).ToString());//set expire date be 1 year before, session expired immediate
            cmd.Parameters.AddWithValue("@id", id);
            int result = sql.executeSQL(cmd);
            if (result == 1)
            {
                return true;
            }
            return false;
        }

        public bool UpdateModifyTime()
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.Setting set priceUpdateTime = getdate()");
            int result = sql.executeSQL(cmd);
            if (result == 1)
            {
                return true;
            }
            return false;
        }

    }
}
