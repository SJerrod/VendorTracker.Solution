using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = VendorsController.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = VendorsController.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);

      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = VendorsController.Find(vendorId);
      Order newOrder = new Order(orderTitle);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;

      model.Add("vendor", foundVendor);
      model.Add("orders", vendorOrders);

      return View("Show", model);
    }
  }
}