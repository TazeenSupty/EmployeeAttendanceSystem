using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empats
{
    public partial class Attendance : System.Web.UI.Page
    {
        SqlConnection con = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["admin_userName"] == null)
                Response.Redirect("~/admin_login.aspx", true);

            if (!IsPostBack)
            {
                LoadGrid();
            }
        }
        protected void DbCon()
        {
            try
            {
                String strCon = "Data Source=DESKTOP-K2H2JBR\\TAZEENSQL;Initial Catalog=EmployeeAttendanceSystem;Integrated Security=True";
                con = new SqlConnection(strCon);
                con.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void LoadGrid()
        {
            DbCon();
            string query = "select * from attendance";
            DataTable dt = new DataTable();
            SqlDataAdapter _da = new SqlDataAdapter(query, con);
            _da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            DbCon();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into attendance (atnd_Id, emp_Id, date, arrive, leave)" +
                    "                                            values (@atnd_Id,@emp_Id,@date,@arrive,@leave)", con);
                cmd.Parameters.AddWithValue("@atnd_Id", tbx_attendanceId.Text);
                cmd.Parameters.AddWithValue("@emp_Id", tbx_empId.Text);
                cmd.Parameters.AddWithValue("@date", tbx_date.Text);
                DateTime.ParseExact(tbx_date.Text, "dd/mm/yyyy",null);
                cmd.Parameters.AddWithValue("@arrive", tbx_arrive.Text);
                DateTime.ParseExact(tbx_arrive.Text, "hh:mm", null);
                cmd.Parameters.AddWithValue("@leave", tbx_leave.Text);
                DateTime.ParseExact(tbx_leave.Text, "hh:mm", null);
                cmd.ExecuteNonQuery();
                lblMessage.Text = "Save Successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                con.Close();
                clearText();
                LoadGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void clearText()
        {
            tbx_empId.Text = tbx_attendanceId.Text = tbx_date.Text = tbx_arrive.Text = tbx_leave.Text = "";
        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {

            DbCon();
            btnSave.Enabled = false;
            SqlCommand cmd = new SqlCommand("select * from attendance where atnd_Id=@atnd_Id", con);
            cmd.Parameters.AddWithValue("@atnd_Id", tbx_attendanceId.Text);
            var dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            if (dt.Rows.Count > 0)
            {
                tbx_attendanceId.Text = dt.Rows[0]["atnd_Id"].ToString();
                tbx_empId.Text = dt.Rows[0]["emp_Id"].ToString();
                tbx_date.Text = dt.Rows[0]["date"].ToString();
                tbx_arrive.Text = dt.Rows[0]["arrive"].ToString();
                tbx_leave.Text = dt.Rows[0]["leave"].ToString();
               
            }
            btnSave.Enabled = true;
            con.Close();
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DbCon();

                SqlCommand cmd = new SqlCommand("delete attendance where atnd_Id=@atnd_Id", con);
                cmd.Parameters.AddWithValue("@atnd_Id", tbx_attendanceId.Text);
                cmd.ExecuteNonQuery();
                lblMessage.Text = "Delete Successfully";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                con.Close();
                LoadGrid();
                tbx_attendanceId.Text = "";
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}