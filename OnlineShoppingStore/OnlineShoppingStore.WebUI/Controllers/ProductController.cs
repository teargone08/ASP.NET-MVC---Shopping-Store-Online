using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        //public ActionResult Index()
        //{
        //    return View();
        //}
        private readonly IProductRepository repository;
        public int PageSize=4; 
        public ProductController(IProductRepository repo)
        {
            this.repository = repo;
        }
        public ActionResult List(string category,int page=1)
        {
            ProductsListViewModel model = new ProductsListViewModel()
            {
                Products=repository.Products
                .Where(p=>category==null||p.Category==category)
                .OrderBy(p=>p.ProductId).Skip((page-1)*PageSize).Take(PageSize),
                PagingInfo=new PagingInfo(){
                    CurrentPage=page,
                    ItemsPerPage=PageSize,
                   // TotalItems=repository.Products.Count()
                   TotalItems=category==null? 
                   repository.Products.Count():repository.Products.Where(p=>p.Category==category).Count()
                },
                CurrentCategory=category
            };
            return View(model);
        }
    }
}