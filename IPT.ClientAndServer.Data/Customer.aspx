<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="IPT.ClientAndServer.Data.Customer" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hotel Management</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>                
                <tr>
                    <td>
                        Customer Name:
                    </td>
                    <td>
                        <input type="text" id="customerName" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Customer FatherName:
                    </td>
                    <td>
                        <input type="text" id="customerFatherName" />
                    </td>
                </tr>
                <tr>
                    <td>
                        PhoneNo:
                    </td>
                    <td>
                        <input type="number" id="phoneNo" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Address:
                    </td>
                    <td>
                        <input type="text" id="address" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Email:
                    </td>
                    <td>
                        <input type="email" id ="email" />
                    </td>
                </tr>
                <tr>
                    <td >
                        <span onclick="addCustomer()">Add Customer</span>
                    </td>
                </tr>

            </table>
            <hr />
            <br /><br />
            <table style="width:100%">
              <tr>                 
                 <th>CustomerName</th> 
                 <th>CustomerFatherName</th>
                 <th>PhoneNo</th>
                 <th>Address</th> 
                 <th>Email</th>              
             </tr>   
             <tr>
               <td>
                 <span id="customerNameValues" ></span>
               </td>
             </tr>
             <tr>
               <td>
                 <span id="customerFatherNameValues" ></span>
               </td>
             </tr>
             <tr>
               <td>
                 <span id="phoneNoValues" ></span>
               </td>
             </tr>
                 <tr>
               <td>
                 <span id="addressValues" ></span>
               </td>
             </tr>
             <tr>
               <td>
                 <span id="emailValues" ></span>
               </td>
             </tr>
           </table>                 
        </div>
    </form>
    <script>
        function addCustomer() {            
            var customerName = $("#customerName").val();
            var customerFatherName = $("#customerFatherName").val();
            var phoneNo = $("#phoneNo").val();
            var address = $("#address").val();
            var email = $("#email").val();

            var customer = new Object();            
            customer.customerName = customerName;
            customer.customerFatherName = customerFatherName;
            customer.phoneNo = phoneNo;
            customer.address = address;
            customer.email = email;

            var customerStr = JSON.stringify(customer);
            $.ajax({
                type: "GET",
                url: "Customer.aspx/AddCustomer",
                contentType: "application/JSON",
                data:
                {
                    customer: customerStr,
                },
                success: function (result) {
                    var data = JSON.parse(result.d);
                    console.log(data);
                    $("#customerNameValues").val(data.customerName);
                    $("#customerFatherNameValues").val(data.customerFatherName);
                    $("#phoneNoValues").val(data.phoneNo);
                    $("#addressValues").val(data.address);
                    $("#emailValues").val(data.email);
                }
            });
        }
    </script>
</body>
</html>
