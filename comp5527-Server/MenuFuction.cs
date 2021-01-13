using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIDemoServer
{
    class MenuFuction
    {
        public bool DeleteMenuType(int menuTypeID)
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.MenuTypeTbl SET valid=0 WHERE id = @id");
            cmd.Parameters.AddWithValue("@id", menuTypeID);
            int result = sql.executeSQL(cmd);
            if (result == 1)
            {
                return true;
            }
            return false;
        }

        public bool DeleteMenu(int menuID)
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.MenuTbl SET valid=0 WHERE id = @id");
            cmd.Parameters.AddWithValue("@id", menuID);
            int result = sql.executeSQL(cmd);
            if (result == 1)
            {
                return true;
            }
            return false;
        }


        public bool AddOrUpdateMenuType(string id, string name)
        {
            SQL sql = new SQL();
            SqlCommand cmd;
            if (!id.Trim().Equals(""))
            {
                //exist id, updata record
                cmd = new SqlCommand("UPDATE dbo.MenuTypeTbl SET name=@name where id=@id");
                cmd.Parameters.AddWithValue("@id", id);
            }
            else
            {
                //not exist id, add new record
                cmd = new SqlCommand("INSERT dbo.MenuTypeTbl(name) VALUES (@name)");
            }
            
            cmd.Parameters.AddWithValue("@name", name);
            int result = sql.executeSQL(cmd);
            if (result == 1)
            {
                return true;
            }
            return false;
        }
        public bool AddOrUpdateMenu(GlobalVar.MenuData newMenu)
        {
            SQL sql = new SQL();
            SqlCommand cmd;
            if (!newMenu.id.Trim().Equals(""))
            {
                //exist id, updata record
                cmd = new SqlCommand("UPDATE dbo.MenuTbl SET typeID=@typeID,name=@name,price=@price,pic=@pic,remark=@remark where id=@id");
                cmd.Parameters.AddWithValue("@id", newMenu.id);
            }
            else
            {
                //not exist id, add new record
                cmd = new SqlCommand("INSERT dbo.MenuTbl(typeID,name,price,pic,remark) VALUES (@typeID,@name,@price,@pic,@remark)");
            }
            cmd.Parameters.AddWithValue("@typeID", newMenu.typeID);
            cmd.Parameters.AddWithValue("@name", newMenu.name);
            cmd.Parameters.AddWithValue("@price", newMenu.price);
            cmd.Parameters.AddWithValue("@pic", newMenu.pic);
            cmd.Parameters.AddWithValue("@remark", newMenu.remark);

            int result = sql.executeSQL(cmd);
            if (result == 1)
            {
                return true;
            }
            return false;
        }
    }
}
