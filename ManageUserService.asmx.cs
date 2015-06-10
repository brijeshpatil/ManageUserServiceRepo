using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for ManageUserService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ManageUserService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        SqlConnection con = new SqlConnection(@"Server=c4b25810-9270-4406-814a-a4b300a3519e.sqlserver.sequelizer.com;Database=dbc4b2581092704406814aa4b300a3519e;User ID=qcpblzjvqmtqizmw;Password=SLeUEYvg6rG37jdgBBTtdghbZHYUnw2sry2DZ34VRDfjvC3BzMjZkiZLCc46aJ2H;");
        SqlDataAdapter da;
        DataSet dt;
        SqlCommand cmd;

        [WebMethod]
        public string InsertNewUser(string FirstName, string LastName)
        {
            cmd = new SqlCommand("insert into userinfo values(@Fname,@Lname)", con);
            cmd.Parameters.AddWithValue("@Fname", FirstName);
            cmd.Parameters.AddWithValue("@Lname", LastName);
            con.Open();
            string Status = cmd.ExecuteNonQuery().ToString();
            con.Close();
            return Status;
        }

        [WebMethod]
        public string UpdateUserInfo(int UserID, string FirstName, string LastName)
        {
            cmd = new SqlCommand("update userinfo set userinfo fname=@Fname,lname=@Lname where userid=@UID", con);
            cmd.Parameters.AddWithValue("@UID", UserID);
            cmd.Parameters.AddWithValue("@Fname", FirstName);
            cmd.Parameters.AddWithValue("@Lname", LastName);
            con.Open();
            string Status = cmd.ExecuteNonQuery().ToString();
            con.Close();
            return Status;
        }

        [WebMethod]
        public string DeleteUser(int UID)
        {
            cmd = new SqlCommand("delete from userinfo where userid=@UID", con);
            cmd.Parameters.AddWithValue("@UID", UID);
            con.Open();
            string Status = cmd.ExecuteNonQuery().ToString();
            con.Close();
            return Status;
        }

        [WebMethod]
        public DataSet GetAllUsers()
        {
            da = new SqlDataAdapter("select * from userinfo", con);
            dt = new DataSet();
            da.Fill(dt);
            return dt;
        }
    }
}
