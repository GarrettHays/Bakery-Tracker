using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
    [TestClass]
    public class VendorTests
    {

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor name", "test vendor description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}
