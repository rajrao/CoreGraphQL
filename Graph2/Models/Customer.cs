﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graph2.Models
{
public class Customer
{
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
    public int BillToCustomerID { get; set; }
    public int CustomerCategoryID { get; set; }
    public int PrimaryContactPersonID { get; set; }
    public int DeliveryMethodID { get; set; }
    public int DeliveryCityID { get; set; }
    public int PostalCityID { get; set; }
    public double CreditLimit { get; set; }
    public string AccountOpenedDate { get; set; }
    public double StandardDiscountPercentage { get; set; }
    public bool IsStatementSent { get; set; }
    public bool IsOnCreditHold { get; set; }
    public int PaymentDays { get; set; }
    public string PhoneNumber { get; set; }
    public string FaxNumber { get; set; }
    public string DeliveryRun { get; set; }
    public string RunPosition { get; set; }
    public string WebsiteURL { get; set; }
    public string DeliveryAddressLine1 { get; set; }
    public string DeliveryAddressLine2 { get; set; }
    public string DeliveryPostalCode { get; set; }
    public string PostalAddressLine1 { get; set; }
    public string PostalAddressLine2 { get; set; }
    public string PostalPostalCode { get; set; }
    public int LastEditedBy { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }

}
}
