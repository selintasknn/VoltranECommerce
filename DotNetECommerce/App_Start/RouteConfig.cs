using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DotNetECommerce
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ProductDetails",
                url: "products/{id}",
                defaults: new { controller = "Products", action = "Details" }
            );
            routes.MapRoute(
                name: "Default",
                url: "products",
                defaults: new { controller = "Products", action = "Index" }
            );
            routes.MapRoute(
                name: "MyCart",
                url: "cart",
                defaults: new { controller = "Products", action = "Cart" }
            );
            routes.MapRoute(
                name: "AddToCart",
                url: "cart/add",
                defaults: new { controller = "Products", action = "AddToCart" }
            );
            routes.MapRoute(
                name: "UpdateCart",
                url: "cart/update",
                defaults: new { controller = "Products", action = "UpdateCart" }
            );
            routes.MapRoute(
                name: "RemoveFromCart",
                url: "cart/remove/{id}",
                defaults: new { controller = "Products", action = "RemoveFromCart" }
            );
            routes.MapRoute(
                name: "About",
                url: "about",
                defaults: new { controller = "Products", action = "About" }
            );
            routes.MapRoute(
                name: "Contact",
                url: "contact",
                defaults: new { controller = "Products", action = "Contact" }
            );
            routes.MapRoute(
                name: "Products",
                url: "",
                defaults: new { controller = "Products", action = "Index" }
            );
        }
    }
}
