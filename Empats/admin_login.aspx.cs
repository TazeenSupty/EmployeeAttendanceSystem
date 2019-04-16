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
    public partial class admin_login : System.Web.UI.Page
    {
        SqlConnection con = null;
        protected void Page_Load(object sender, EventArgs e)
        {

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
        protected void Button1_Click(object sender, EventArgs e)
        {
            String userName = tbx_admin_userName.Text;
            String password = tbx_admin_password.Text;

            DbCon();

            SqlCommand cmd = new SqlCommand("select * from admin_login_table where admin_userName=@userName and admin_password=@password", con);
            cmd.Parameters.AddWithValue("@UserName", userName);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            if (dt.Rows.Count > 0)
            {
                //session
                Session["admin_userName"] = dt.Rows[0]["admin_userName"].ToString();
                Response.Redirect("~/admin_home.aspx", true);

                //Cookies
                //Response.Cookies["UserName"].Value= dt.Rows[0]["UserName"].ToString();
                //Response.Cookies["UserName"].Expires = DateTime.Now.AddHours(1);

                //OR
                //HttpCookie cok = new HttpCookie("cookieName");
                //cok.Value= dt.Rows[0]["UserName"].ToString();
                //cok.Expires = DateTime.Now.AddHours(1);
                //Response.Cookies.Add(cok);

            }
            else
            {
                lbl_errorMsg.Text = "Login Failed";
            }
            con.Close();
        }
    }
}