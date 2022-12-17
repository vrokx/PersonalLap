using RepoPractice.Models.DAL.Product;
using RepoPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;
using System.Collections;

namespace RepoPractice.Controllers
{
    public class BuyerController : Controller
    {
        private IRepository<UserModel> userObj;
        private IRepository<ProductModel> productObj;
        private IRepository<CartModel> cartObj;
        private IRepository<OrderModel> orderObj;

        public BuyerController()
        {
            this.productObj = new GenericRepository<ProductModel>();
            this.userObj = new GenericRepository<UserModel>();
            this.cartObj = new GenericRepository<CartModel>();
            this.orderObj = new GenericRepository<OrderModel>();
        }

        //public ActionResult SendMail(int? id)
        //{
        //    UserModel i = userObj.GetAllById(Convert.ToInt32(id));
        //    return View(i);
        //}

        //[HttpPost]
        public ActionResult SendMail()
        {
            //var myList = (from i in orderObj.GetAll() select i).ToList();
            //string body = string.Join(",", myList);

            MailMessage mm = new MailMessage("radhakrishna36495@gmail.com", User.Identity.Name);
            mm.Subject = "Order Confirmed";
            mm.Body = "Body";
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;


            NetworkCredential nc = new NetworkCredential("radhakrishna36495@gmail.com", "iufedzbfhqlpypdl");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = nc;
            smtp.Send(mm);
            return Content("Mail Sent");
        }

        public ActionResult BuyerDisplayAllProduct()
        {
            return View(from i in productObj.GetAll() select i);
        }

        [Authorize]
        public ActionResult AddToCart(int id , string qty )
        {
            ProductModel p = productObj.GetAllById(id);

            CartModel co = new CartModel();

            co.ProductModel_ProductId = p.ProductId;

            TempData["id"]  = co.ProductModel_ProductId;

            cartObj.Add(co);
            cartObj.Save();
            return RedirectToAction("ViewCart");
        }
        [Authorize]
        public ActionResult ViewCart()
        {
            int id = Convert.ToInt32(TempData["id"]);

            var data = productObj.GetAllById(id);

            return View(data);
        }
    }
}