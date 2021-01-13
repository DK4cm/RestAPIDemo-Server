using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIDemoServer
{
    public static class GlobalVar
    {
        public struct StaffData
        {
            public int id;
            public string account;
            public string name;
            public string gender;
            public int permission;
            public string passwordHash;
            public string remark;
        }

        public struct MenuData
        {
            public string id;   //should be int, but use string for esay judge it is new item or not 
            public int typeID;
            public string name;
            public string price;
            public string pic;
            public string remark;
        }

        public static StaffData currentUser = new StaffData();

        public static Boolean UpdateSales = false; 
    }
}
