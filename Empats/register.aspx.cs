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
    public partial class register : System.Web.UI.Page
    {
        SqlConnection con = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["admin_userName"] == null)
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
            string query = "select * from employee";
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
                SqlCommand cmd = new SqlCommand("insert into employee (emp_Id,emp_Name,emp_Username,emp_Password,emp_Designation,emp_Email,emp_Address,emp_Age)" +
                    "                                  values (@emp_Id,@emp_Name,@emp_Username,@emp_Password,@emp_Designation,@emp_Email,@emp_Address,@emp_Age)", con);
                cmd.Parameters.AddWithValue("@emp_Id", tbx_empId.Text);
                cmd.Parameters.AddWithValue("@emp_Name", tbx_empName.Text);
                cmd.Parameters.AddWithValue("@emp_Username", tbx_empUsername.Text);
                cmd.Parameters.AddWithValue("@emp_Password", tbx_empPassword.Text);
                cmd.Parameters.AddWithValue("@emp_Designation", tbx_empDesignation.Text);
                cmd.Parameters.AddWithValue("@emp_Email", tbx_empEmail.Text);
                cmd.Parameters.AddWithValue("@emp_Address", tbx_empAddress.Text);
                cmd.Parameters.AddWithValue("@emp_Age", tbx_empAge.Text.ToString());
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
            tbx_empId.Text = tbx_empName.Text = tbx_empUsername.Text= tbx_empPassword.Text= tbx_empDesignation.Text = tbx_empEmail.Text = tbx_empAddress.Text = tbx_empAge.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {

            DbCon();
            btnSave.Enabled = false;
            SqlCommand cmd = new SqlCommand("select * from employee where emp_Id=@emp_Id", con);
            cmd.Parameters.AddWithValue("@emp_Id", tbx_empId.Text);
            var dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            if (dt.Rows.Count > 0)
            {
                tbx_empId.Text = dt.Rows[0]["emp_Id"].ToString();
                tbx_empName.Text = dt.Rows[0]["emp_Name"].ToString();
                tbx_empUsername.Text = dt.Rows[0]["emp_Username"].ToString();
                tbx_empPassword.Text = dt.Rows[0]["emp_Password"].ToString();
                tbx_empDesignation.Text = dt.Rows[0]["emp_Designation"].ToString();
                tbx_empEmail.Text = dt.Rows[0]["emp_Email"].ToString();
                tbx_empAddress.Text = dt.Rows[0]["emp_Address"].ToString();
                tbx_empAge.Text = dt.Rows[0]["emp_Age"].ToString();
            }
            btnSave.Enabled = true;
            con.Close();
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DbCon();

                SqlCommand cmd = new SqlCommand("delete employee where emp_Id=@emp_Id", con);
                cmd.Parameters.AddWithValue("@emp_Id", tbx_empId.Text);
                cmd.ExecuteNonQuery();
                lblMessage.Text = "Delete Successfully";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                con.Close();
                LoadGrid();
                tbx_empId.Text = "";
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}