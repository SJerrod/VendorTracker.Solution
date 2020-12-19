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
  }
}