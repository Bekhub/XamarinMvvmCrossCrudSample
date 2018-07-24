using System;
using System.Collections.Generic;
using MvvmCross.ViewModels;

namespace MvvmCrossCrudSample.Core.ViewModels
{
  public class CustomersViewModel : MvxViewModel
  {
    private List<Customer> _customers;
    public List<Customer> Customers
    {
      get => _customers;
      set => SetProperty(ref _customers, value);
    }
    public CustomersViewModel()
    {
      Customers = new List<Customer>(){
        new Customer(){Id =1, Name="Bekhzod", Description = "A good person"},
        new Customer(){Id =2, Name="Sergiuzh", Description = "Potencial customer"},
        new Customer(){Id=3, Name="Boris", Description="Student in Moscow city"},
        new Customer(){Id=4, Name="Allaev", Description="Young programmer"}
      };
    }
    public class Customer
    {
      public int Id { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
    }
  }

}
