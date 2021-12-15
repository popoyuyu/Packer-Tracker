using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PackerTracker.Models;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test", true, 2.3);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      string name1 = "pillow";
      string name2 = "sleeping bag";
      bool forName1 = true;
      bool forName2 = false;
      double weight1 = 0.8;
      double weight2 = 5;
      Item newItem1 = new Item(name1, forName1, weight1);
      Item newItem2 = new Item(name2, forName2, weight2);
      List<Item> newList = new List<Item> { newItem1, newItem2 };
    }
  }
}