using PAL.Portal.v4.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PAL.Portal.v4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
           // ViewBag.Message = "Your contact page.";
           
            return View();
        }

        

        [HttpPost]
        public ActionResult Contact(CQueries custData)
        {
            string constr = ConfigurationManager.ConnectionStrings["CONSTR1"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "INSERT INTO CQueries(NAME, EMAIL, PHONENO, COMPANYNAME, QSUBJECT, QMESSAGE, CREATEDAT) VALUES(@NAME, @EMAIL, @PHONENO, @COMPANYNAME, @QSUBJECT, @QMESSAGE, @CREATEDAT)";
               //  query += " SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@NAME", custData.NAME);
                    cmd.Parameters.AddWithValue("@EMAIL", custData.EMAIL);
                    cmd.Parameters.AddWithValue("@PHONENO", custData.PHONENO);
                    cmd.Parameters.AddWithValue("@COMPANYNAME", custData.COMPANYNAME);
                    cmd.Parameters.AddWithValue("@QSUBJECT", custData.QSUBJECT);
                    cmd.Parameters.AddWithValue("@QMESSAGE", custData.QMESSAGE);
                    cmd.Parameters.AddWithValue("@CREATEDAT", DateTime.Now);
                    // var id = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    ViewBag.Message = "Thanks for contacting with us. Your message have been saved. \n Our fearless team will get back to you very soon.";
                    //custData.COMPANYNAME = string.Empty;
                    //custData.EMAIL = string.Empty;
                    //custData.NAME = string.Empty;
                    //custData.PHONENO = string.Empty;
                    //custData.QMESSAGE = string.Empty;
                    //custData.QSUBJECT = string.Empty;                    
                    //custData = null;
                }
                return Contact();
            }           
        }        
    }
}