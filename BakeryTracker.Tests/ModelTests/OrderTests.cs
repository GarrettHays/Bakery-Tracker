using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryTracker.Models;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test title", "test description", "test price", "test date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetInfo_ReturnsInfo_String()
    {
      //Arrange
      string title = "meat order";
      string description = "13# ground beef";
      string price = "$40";
      string date = "12/19/21";

      //Act
      Order newOrder = new Order(title, description, price, date);
      string titleResult = newOrder.Title;
      string descriptionResult = newOrder.Description;
      string priceResult = newOrder.Price;
      string dateResult = newOrder.Date;

      //Assert
      Assert.AreEqual(title, titleResult);
      Assert.AreEqual(description, descriptionResult);
      Assert.AreEqual(price, priceResult);
      Assert.AreEqual(date, dateResult);

    }

    [TestMethod]
    public void SetOrderInfo_SetNameDescriptionPriceDate_String()
    {
      //Arrange
      string title = "meat order";
      string description = "13# ground beef";
      string price = "$40";
      string date = "12/19/21";
      Order newOrder = new Order(title, description, price, date);

      //Act
      string updatedTitle = "bread order";
      string updatedDescription = "50 loaves of bread";
      string updatedPrice = "$50";
      string updatedDate = "01/20/22";
      newOrder.Title = updatedTitle;
      newOrder.Description = updatedDescription;
      newOrder.Price = updatedPrice;
      newOrder.Date = updatedDate;
      string titleResult = newOrder.Title;
      string descriptionResult = newOrder.Description;
      string priceResult = newOrder.Price;
      string dateResult = newOrder.Date;

      //Assert
      Assert.AreEqual(updatedTitle, titleResult);
      Assert.AreEqual(updatedDescription, descriptionResult);
      Assert.AreEqual(updatedPrice, priceResult);
      Assert.AreEqual(updatedDate, dateResult);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string title1 = "meat order";
      string description1 = "13# ground beef";
      string price1 = "$40";
      string date1 = "12/19/21";
      string title2 = "bread order";
      string description2 = "50 loaves of bread";
      string price2 = "$50";
      string date2 = "01/20/22";
    
      Order newOrder1 = new Order(title1, description1, price1, date1);
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "bread order";
      string description = "50 loaves of bread";
      string price = "$50";
      string date = "01/20/22";
    
      Order newOrder = new Order(title, description, price, date);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string title1 = "meat order";
      string description1 = "13# ground beef";
      string price1 = "$40";
      string date1 = "12/19/21";
      string title2 = "bread order";
      string description2 = "50 loaves of bread";
      string price2 = "$50";
      string date2 = "01/20/22";
      Order newOrder1 = new Order(title1, description1, price1, date1);
      Order newOrder2 = new Order(title2, description2, price2, date2);

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }
  }
}