using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor ("name", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorProperties_AddPropertiesToVendor_Properties()
    {
      string name = "Jessies Cafe";
      string description = "Local Coffee shop";
      Vendor newVendor = new Vendor(name, description);
      int id = newVendor.Id;
      string resultName = newVendor.Name;
      string resultDescription = newVendor.Description;
      Assert.AreEqual(name, resultName);
      Assert.AreEqual(description, resultDescription);
      Assert.AreEqual(1, id);
    }

    [TestMethod]
    public void GetAll_ShowsAllVendorObjects_VendorList()
    {
      string vendor1 = "Jessies Cafe";
      string vendor2 = "Dougs Doughnuts";
      Vendor newVendor1 = new Vendor(vendor1, "Local Coffee");
      Vendor newVendor2 = new Vendor(vendor2, "Local Doughnuts");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnVendorById_Vendor()
    {
      string vendor1 = "Jessies Cafe";
      string vendor2 = "Dougs Doughnuts";
      Vendor newVendor1 = new Vendor(vendor1, "Local Coffee");
      Vendor newVendor2 = new Vendor(vendor2, "Local Doughnuts");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AddsOrderToVendor_OrderList()
    {
      string orderTitle = "Bread Order";
      DateTime dates = new DateTime(2014, 6, 14, 6, 32, 0);
      Order newOrder = new Order(orderTitle, "description", "$1.00", dates);
      List<Order> newList = new List<Order> { newOrder };
      string vendor1 = "Jessies Cafe";
      Vendor newVendor = new Vendor(vendor1, "Local Cafe");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}