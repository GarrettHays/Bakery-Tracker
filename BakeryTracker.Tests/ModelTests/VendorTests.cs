using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorInfo_ReturnsInfo_String()
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

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Vinny";
      string description01 = "Meat Vendor";
      string name02 = "Sally";
      string description02 = "Salad Vendor";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Vinny";
      string description01 = "Meat Vendor";
      string name02 = "Sally";
      string description02 = "Salad Vendor";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_ItemList()
    {
    //Arrange
    string title = "meat order";
    string description = "13# ground beef";
    string price = "$40";
    string date = "12/19/21";
    Order newOrder = new Order(title,description, price, date);
    List<Order> newList = new List<Order> { newOrder };
    string name = "Vinny";
    string description1 = "Meat Vendor";
    Vendor newVendor = new Vendor(name, description1);
    newVendor.AddOrder(newOrder);

    //Act
    List<Order> result = newVendor.Orders;

    //Assert
    CollectionAssert.AreEqual(newList, result);
    }
  }
}