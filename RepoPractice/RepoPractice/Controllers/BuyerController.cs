using RepoPractice.Models.DAL.Product;
using RepoPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepoPractice.Controllers
{
    public class BuyerController : Controller
    {
        private IRepository<UserModel> userObj;
        private IRepository<ProductModel> productObj;
        private IRepository<CartModel> cartObj;

        public BuyerController()
        {
            this.productObj = new GenericRepository<ProductModel>();
            this.userObj = new GenericRepository<UserModel>();
            this.cartObj = new GenericRepository<CartModel>();
        }
        public ActionResult BuyerDisplayAllProduct()
        {
            return View(from i in productObj.GetAll() select i);
        }

        [Authorize]
        public ActionResult AddToCart(int id)
        {
            ProductModel p = productObj.GetAllById(id);

            CartModel co = new CartModel();

            co.ProductModel = p;

            cartObj.Add(co);
            cartObj.Save();
            return Content("Added To Cart");
        }
        [Authorize]
        public ActionResult ViewCart()
        {
            var data = (from i in cartObj.GetAll() select i).ToList();

            return View(data);
        }
    }
}