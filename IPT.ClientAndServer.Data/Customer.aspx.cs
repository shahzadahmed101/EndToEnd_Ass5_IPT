using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using IPT.Hotel.Data.Helpers;
using Newtonsoft.Json;

namespace IPT.ClientAndServer.Data
{
    public partial class Customer : System.Web.UI.Page
    {
        static CustomerHelper customerHelper;
        protected void Page_Load(object sender, EventArgs e)
        {
            customerHelper = new CustomerHelper();
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat =ResponseFormat.Json,UseHttpGet =true)]

        public static string AddCustomer()
        {
            var customerStr = HttpContext.Current.Request["customer"];

            var customer = JsonConvert.DeserializeObject<CustomerModel>(customerStr);
            customerHelper.Insert(customer.CustomerName, customer.CustomerFatherName, customer.PhoneNo, customer.Address, customer.Email);

            var allRecords = customerHelper.GetAllCustomer();
            var allRecordsConverter = new List<CustomerModel>();
            foreach(var customersRecord in allRecords )
            {
                var c = new CustomerModel();
                c.CustomerName = customersRecord.Name;
                c.CustomerFatherName = customersRecord.FatherName;
                c.PhoneNo = customersRecord.Phone;
                c.Address = customersRecord.Address;
                c.Email = customersRecord.Email;

                allRecordsConverter.Add(c);
            }
            var allRecordStr = JsonConvert.SerializeObject(allRecordsConverter);
            return allRecordStr;

        }
        public class CustomerModel
        {
            public string CustomerName { get; set; }
            public string CustomerFatherName { get; set; }
            public string PhoneNo { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
        }
    }
}