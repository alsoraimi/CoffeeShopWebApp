using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab20.Models;
using System.Data.SqlClient;

namespace lab20.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CoffeeShopDBEntities CoffeeShopDB = new CoffeeShopDBEntities();
            List<Item> ItemList = CoffeeShopDB.Items.ToList();
            ViewBag.ItemList = ItemList;


            return View();
        }
        public ActionResult Register()
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AddUser(UserInfo NewUser)
        {
            //MUST VALIDATE HERE!!!!!
            // TO ADD THE DATA FROM THE MODEL TO THE DATABASE
            return View(NewUser); //pass the newuser model to the adduser view. another way to pass more info than what view bag does.
        }
  
    }
}