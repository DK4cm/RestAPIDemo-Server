using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestAPIDemoServer
{
    public partial class OrderDetail : Form
    {
        string tableID = "";
        string orderID = "";
        public OrderDetail(string _tableID)
        {
            InitializeComponent();
            tableID = _tableID;
            orderID = GetOrderIDFromTableID(tableID);
        }

        private string GetOrderIDFromTableID(string _TableID)
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("select id from OrderTbl where isPay=0 and tableID = @tableID");
            cmd.Parameters.AddWithValue("@tableID", _TableID);
            DataTable dt = sql.executeSQLQuery(cmd);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["id"].ToString();
            }
            return "";
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("select itemName AS \"Ordered Item\",unitPrice AS \"Unit Price\",num AS \"Unit\",totalPrice AS \"Sub Total\" from OrderDetail where orderid = @orderid and valid=1");
            cmd.Parameters.AddWithValue("@orderid", orderID);
            DataTable dt = sql.executeSQLQuery(cmd);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.NullValue = "";
            if (dt.Rows.Count > 1)
            {
                dataGridView1.Columns["Unit Price"].DefaultCellStyle.Format = "c";
                dataGridView1.Columns["Sub Total"].DefaultCellStyle.Format = "c";
            }

            //update total
            SQL sql2 = new SQL();
            SqlCommand cmd2 = new SqlCommand("select sum(totalPrice) AS SUM from OrderDetail where valid=1 and orderID = @orderid");
            cmd2.Parameters.AddWithValue("@orderid", orderID);
            DataTable dt2 = sql2.executeSQLQuery(cmd2);
            if (dt2.Rows[0]["SUM"].ToString().Trim().Equals(""))    //empty
            {
                tb_total.Text = "0.00";
            }
            else
            {
                tb_total.Text = double.Parse(dt2.Rows[0]["SUM"].ToString()).ToString("c");
            }


            //update interface
            SQL sql3 = new SQL();
            SqlCommand cmd3 = new SqlCommand("select a.id AS \"Order ID\",a.orderTime AS \"Order Time\",c.num AS \"Table Num\",a.personalNum AS \"No. of Person\",a.billRequested AS \"Bill Requested\",b.account AS \"Staff\" from ordertbl a left join StaffTbl b on a.staffID = b.id left join tableTbl c on a.tableID = c.id where a.isPay = 0 and a.id = @orderid");
            cmd3.Parameters.AddWithValue("@orderid", orderID);
            DataTable dt3 = sql3.executeSQLQuery(cmd3);
            tb_noOfPerson.Text = dt3.Rows[0]["No. of Person"].ToString();
            tb_orderID.Text = dt3.Rows[0]["Order ID"].ToString();
            tb_OrderTime.Text = dt3.Rows[0]["Order Time"].ToString();
            tb_Staff.Text = dt3.Rows[0]["Staff"].ToString();
            tb_tableNo.Text = dt3.Rows[0]["Table Num"].ToString();
            //if (!bool.Parse(dt3.Rows[0]["Bill Requested"].ToString()))
            //{
            //    btn_billrequest.Enabled = false;
            //}
        }

        private void btn_billrequest_Click(object sender, EventArgs e)
        {
            //set pay=1,bill request=0
            SQL sql = new SQL();
            SqlCommand cmd = new SqlCommand("UPDATE ordertbl SET isPay=1, billRequested=0 WHERE id=@orderid");
            cmd.Parameters.AddWithValue("@orderid", orderID);
            sql.executeSQL(cmd);

            //set table state = 0 
            cmd = new SqlCommand("UPDATE TableTbl SET flag=0 WHERE id=@tableID");
            cmd.Parameters.AddWithValue("@tableID", tableID);
            sql.executeSQL(cmd);
            this.Close();
        }
    }
}
