using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      DateTime time = new DateTime(2018, 5, 26);
      Order newOrder = new Order ("title", "description", "price", time);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderProperties_AddPropertiesToOrder_Properties()
    {
      string title = "Publix";
      string description = "Grocery Store";
      string price = "$5.00";
      DateTime time = new DateTime(2018, 5, 26);
      Order newOrder = new Order (title, description, price, time);
      int id = newOrder.Id;
      string resultTitle = newOrder.Title;
      string resultDescription = newOrder.Description;
      Assert.AreEqual(title, resultTitle);
      Assert.AreEqual(description, resultDescription);
      Assert.AreEqual(1, id);
    }

    [TestMethod]
    public void GetAll_ShowsAllOrderObjects_OrderList()
    {
      string order1 = "Publix";
      DateTime time1 = new DateTime(2018, 5, 26);
      string order2 = "Albertsons";
      DateTime time2 = new DateTime(2018, 5, 27);
      Order newOrder1 = new Order(order1, "description", "price", time1);
      Order newOrder2 = new Order(order2, "description", "price", time2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnOrderById_Order()
    {
      string order1 = "Publix";
      DateTime time1 = new DateTime(2018, 5, 26);
      string order2 = "Albertsons";
      DateTime time2 = new DateTime(2018, 5, 27);
      Order newOrder1 = new Order(order1, "description", "price", time1);
      Order newOrder2 = new Order(order2, "description", "price", time2);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}