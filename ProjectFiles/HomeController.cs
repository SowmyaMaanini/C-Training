using System.Linq;
using System.Web.Mvc;
using WebApplication10.Models;
using System.Data;
using static System.Collections.Generic.IEnumerable<WebApplication10.Models.orderdetail>;
namespace WebApplication10.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            userdetail usd = new userdetail();
            return View(usd);
        }
        [HttpPost]
        public ActionResult Login(userdetail usd)
        {
            using (DbModels pmd = new DbModels())
            {
                pmd.userdetails.Add(usd);
                pmd.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Login Successful";
            return View();
        }

        //public ActionResult Order()
        //{


        //    return View();
        //}
        [HttpGet]
        public ActionResult Order()
        {
            //SqlConnection sqlcon = new SqlConnection("Data source=SUNNY\\SUNNYSQL; database =project;user id=sa;password=Naani@123");

            // //string con = ConfigurationManager.ConnectionStrings["Default Connection"].ConnectionString;
            // //SqlConnection sqlcon = new SqlConnection(con);
            // string sqlquery = "Insert into [dbo.][orderdetails](PizzaName,orderdate,Address,CreditcardNo) values (@pname,getdate(),@add,@ccn)";
            // SqlCommand cmd = new SqlCommand(sqlquery, sqlcon);

            // cmd.Parameters.AddWithValue("@pname", ord.PizzaName);
            //  cmd.Parameters.AddWithValue("@add", ord.Address);
            //  cmd.Parameters.AddWithValue("@ccn", ord.CreditcardNo);
            // sqlcon.Open();

            // sqlcon.Close();
            // ViewData["Message"] = "Order Placed Successfully";
            orderdetail ord = new orderdetail();
            return View(ord);
        }
        [HttpPost]
        public ActionResult Order(orderdetail ord)
        {
            using (DbModels dbm = new DbModels())
            {
                dbm.orderdetails.Add(ord);
                dbm.SaveChanges();

                return View();
            }

        }




        public ActionResult Summary()
        {
            using (DbModels dbm = new DbModels())
            {
                return View(dbm.orderdetails.ToList());
            }
        }
        //public ActionResult Details(int id = 1)
        //{
        //    using (DbModels dbm = new DbModels())
        //    {
        //        return View(dbm.orderdetails.Where(x => x.OrderId == id).FirstOrDefault());
        //    }
        //}
        //public ActionResult Display(string a)
        //{
        //    using (DbModels dbm= new DbModels())
        //    {
        //        return View(dbm.orderdetails.Where(x => x.PizzaName==a).FirstOrDefault());
        //    }
            
        //}



        //" OrderID - " + order.OrderId + " ," + "PizzaName -" + order.PizzaName + " , " +"Address -" +order.Address+ " ," +"CreditCardNumber -" +order.CreditcardNo+ ". ";




        //    }

        //}

        //public ActionResult Order(FormCollection frm, string action)
        //{


        //    string PizzaName = frm["PizzaName"];
        //    string Address = frm["Address"];
        //    string CreditcardNo = frm["CreditcardNo"];
        //    orderdetail obj = new orderdetail();
        //    //obj.update(OrderId, PizzaName, Address, CreditcardNo);
        //    DataTable dt = new DataTable();
        //    dt = obj.GetOrder();
        //    return View("Status", dt);

        //}
        //public DataTable Page()
        //{
        //    SqlConnection con = new SqlConnection("Data source=SUNNY\\SUNNYSQL; database =project;user id=sa;password=Naani@123");
        //    string selqry = "select OrderId,PizzaName,Address,CreditcardNo from orderdetail";
        //    SqlDataAdapter da = new SqlDataAdapter(selqry, con);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;

        //public ActionResult Status()
        //{
        //SqlConnection conn = new SqlConnection("Data source=SUNNY\\SUNNYSQL; database =project;user id=sa;password=Naani@123");
        //String connectionString = "<THE CONNECTION STRING HERE>";
        //    String sql = "SELECT * FROM students";
        //    SqlCommand cmd = new SqlCommand(sql, conn);

        //    var model = new List<orderdetail>();
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        conn.Open();
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            var orderdetails = new orderdetail();
        //            orderdetails.OrderId = (int)rdr["OrderId"];
        //            orderdetails.PizzaName = (string)rdr["PizzaName"];
        //            orderdetails.Address = (string)rdr["Adress"];
        //        orderdetails.CreditcardNo = (string)rdr["CreditcardNo"];
        //            model.Add(orderdetails);
        //        }

        //    }

        //    return View(model);
        //}

    }
    }


