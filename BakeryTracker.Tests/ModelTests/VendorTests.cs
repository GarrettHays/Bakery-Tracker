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

    [TestMethod]
    public void GetVendorInfo_ReturnsVendorInfo_String()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string nameResult = newVendor.Name;
      string descriptionResult = newVendor.Description;

      //Assert
      Assert.AreEqual(name, nameResult);
      Assert.AreEqual(description, descriptionResult);
    }
  }
}
