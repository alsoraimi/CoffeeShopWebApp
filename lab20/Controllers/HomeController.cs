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

        public ActionResult DeleteItem(string Name)

        {

            try
            {

                CoffeeShopDBEntities CoffeeShopDB = new CoffeeShopDBEntities();

                if (Name == null)
                {

                    string ErrorMessage = "Error, Item Name does not exist";
                    ViewBag.ErrorMessage = ErrorMessage;
                    return View("ErrorMessages");
                }

                Item ToDelete = CoffeeShopDB.Items.Find(Name);
                CoffeeShopDB.Items.Remove(ToDelete);
                CoffeeShopDB.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            catch(Exception)
            {
                ViewBag.ErrorMessage = "Sorry! There seems to be an error.";
                return View("ErrorMessages");


            }

            


        }

        public ActionResult UpdateItem(string Name)
        {

            CoffeeShopDBEntities CoffeeShopDB = new CoffeeShopDBEntities();
            Item ToFind = CoffeeShopDB.Items.Find(Name);
            return View("UpdateItem");
            

        }

        public ActionResult SaveUpdates(Item ToBeUpdated)
        {
            CoffeeShopDBEntities CoffeeShopDB = new CoffeeShopDBEntities();
            Item ToFind = CoffeeShopDB.Items.Find(ToBeUpdated.Name);
            ToFind.Description = ToBeUpdated.Description;
            ToFind.Price = ToBeUpdated.Price;
            ToFind.Quantity = ToBeUpdated.Quantity;

            CoffeeShopDB.SaveChanges();
            return RedirectToAction("Index");



        }

        public ActionResult AddItem()
        {
            return View();
        }

        public ActionResult SaveNewItem(Item NewItem)
        {

            CoffeeShopDBEntities CoffeeShopDB = new CoffeeShopDBEntities();
            CoffeeShopDB.Items.Add(NewItem);
            CoffeeShopDB.SaveChanges();

            return RedirectToAction("Index");


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