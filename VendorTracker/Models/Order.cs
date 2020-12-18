using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    //public DateTime Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order (string orderTitle, string orderDescription, string orderPrice)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = orderPrice;
      //Date = orderDate;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int orderId)
    {
      return _instances[orderId-1];
    }
  }
}