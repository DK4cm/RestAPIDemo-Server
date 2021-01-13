using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIDemoServer
{
    class TableFunction
    {
        public bool DeleteTable(int tableID)
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.TableTbl SET valid=0 WHERE id = @id and flag <> 1");
            cmd.Parameters.AddWithValue("@id", tableID);
            int result = sql.executeSQL(cmd);
            if (result == 1)
            {
                return true;
            }
            return false;
        }

        private bool CheckTableID(int id)
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("SELECT id FROM dbo.TableTbl WHERE id = @id");
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dt = sql.executeSQLQuery(cmd);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }

        public bool AddOrUpdateTable(string id, int num, string description)
        {
            SQL sql = new SQL();
            SqlCommand cmd;
            if (!id.Trim().Equals(""))
            {
                //exist tableid, updata record
                cmd = new SqlCommand("UPDATE dbo.TableTbl SET num=@num,description=@description WHERE id=@id");
                cmd.Parameters.AddWithValue("@id", id);
            }
            else
            {
                //not exist id, add new record
                cmd = new SqlCommand("INSERT INTO dbo.TableTbl(num,description) VALUES (@num,@description)");
            }
            cmd.Parameters.AddWithValue("@num", num);
            cmd.Parameters.AddWithValue("@description", description);
            int result = sql.executeSQL(cmd);
            if (result == 1)
            {
                return true;
            }
            return false;
        }

        public bool CheckTableState(string id)
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("SELECT id FROM dbo.TableTbl WHERE id = @id and flag=1");
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dt = sql.executeSQLQuery(cmd);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
    }
}
