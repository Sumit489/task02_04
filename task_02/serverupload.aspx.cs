using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task_02
{
    public partial class serverupload : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["string"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Server.MapPath("Images")))
            {
                Directory.CreateDirectory(Server.MapPath("Images"));
            }
            string imageurl = (Server.MapPath("Images") + "\\" + image.FileName);
            string dbpath = "~/Images/" + image.FileName;
            image.SaveAs(imageurl);

            SqlCommand cmd = new SqlCommand("insert into imageurl(imageurl,imagename) values (@url,@name) ", con);
            cmd.Parameters.AddWithValue("@url", dbpath);
            cmd.Parameters.AddWithValue("@name", name.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}