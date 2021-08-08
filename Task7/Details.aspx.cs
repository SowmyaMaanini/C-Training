using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("E:\\Training\\Details.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            
            Response.Write(sr.ReadToEnd());
            
            sr.Close();
            fs.Close();
        }
    }
}