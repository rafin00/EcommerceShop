using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;

namespace Data
{
   public class Cusdb
    {
       // DataClasses1DataContext data = new DataClasses1DataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\Documents\Visual Studio 2012\Projects\Cshpro\Data\Database1.mdf;Integrated Security=True");
       // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\Documents\Visual Studio 2012\Projects\Cshpro\Data\Database1.mdf;Integrated Security=True");
        Connection con = new Connection();
       /* public string insertcus(Customer cus)
        {
            data.Customers.InsertOnSubmit(cus);
            data.SubmitChanges();
            return "REgistered!"+cus.address;
        }*/

        public object login( user us)
        {
            string query = "Select * From Customer where cususername = '" + us.username + "' and password = '" + us.password+"'";
            return con.login(query);
        }

        public bool adminlogin(admin ad)
        {
            string query = "Select * From Admin where username = '" + ad.username + "' and password = '" + ad.password + "'";
            return con.adminlogin(query);
        }

        public bool add(user us)
        {
            string query = "INSERT INTO Customer (cususername, email, address, password, name, phone) VALUES ('" + us.username + "', '" + us.email + "', '" + us.address + "', '" + us.password + "', '" + us.name + "', '" + us.phone + "')";
            return con.add(query);
        }

        public bool add(Staff st)
        {
            string query = "INSERT INTO Deliver (delusername, name, phone, password) VALUES ('" + st.username + "', '" + st.name + "', '" + st.phone + "', '" + st.password + "')";
            return con.add(query);
        }



        public bool addproduct(Products pd)
        {
            
            string query = "INSERT INTO Product(name,price,quantity,image,type,path)VALUES('" +pd.name + "'," +pd.price + "," + pd.quantity + ",@img,'"+pd.type+"','"+pd.path+"');";

            return con.add(query,pd.img);
        }

        public object serach(Products pd)
        {
            string query = "Select * from Product where productid = '"+pd.productid+"'";
            return con.search(query);
        }

        public bool updateproduct(Products pd)
        {
            string query = "UPDATe Product SET name = '"+pd.name+"', price= "+pd.price+", quantity="+pd.quantity+" , path ='"+pd.path+"', image = @img WHERE productid = "+pd.productid+";";
            return con.updateproduct(query,pd.img);
        }

        public bool deleteproduct(Products pd)
        {
            string query = "DELETE FROM Product WHERE productid = '"+pd.productid+"';";

            return con.deleteproduct(query);
        }

        public object serach(Staff st)
        {
            string query = "Select * from Deliver where delusername = '" + st.username + "'";
            return con.searchstaff(query);
        }

        public bool deletestaff(Staff st)
        {
            string query = "DELETE FROM Deliver WHERE delusername = '" + st.username + "';";

            return con.deleteproduct(query);
        }

        public bool updatestaff(Staff st)
        {
            string query = "UPDATe Deliver SET name = '" + st.name + "', phone= '" + st.phone + "', password='" + st.password + "';";
            return con.updatestaff(query);
        }

        public System.Data.DataTable gettable()
        {
            string query = "Select delusername as Username, name as Name, phone as Phone, password as Password from Deliver";
            return  con.gettable(query);
        
        }

        public System.Data.DataTable getuitable()
        {
            string query = "Select productid as [Product ID], name as Name, price as Price, quantity as Quantity, image as Image  from Product where quantity > 0";
            return con.gettable(query);
        }

        public bool addtochart(Products pd,user us)
        {
           
            string qchart = "INSERT INTO Chart(id,productid,quantity,price)VALUES(@id," + pd.productid + "," + pd.quantity + "," + pd.price+");";
           
            return con.addtochart(qchart);
        }

        public bool genorder(user us)
        {
            string qorder = "Insert into Orders(cususername)values('" + us.username + "')";
            string qoid = "SELECT max(Id) FROM Orders;";
            return con.genorder(qorder,qoid);
        }



        public object getsctable()
        {
            string query = "Select productid as [Product ID], quantity as Quantity, price as Price  from Chart where id = @val";
            return con.getsctable(query);
        }

        public string gettotal()
        {
            string query = "SELECT SUM(price) FROM Chart WHERE condition id=@val;";
            return con.gettotal(query);
        }

        public bool cashout(int total)
        {
            string query = "UPDATE Customer SET due = "+total+" + due WHERE cususername = (select cususername from Orders where Id = @val) ";
            /*INSERT INTO Customers (CustomerName, City, Country)
SELECT SupplierName, City, Country FROM Suppliers;

            SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate
FROM Orders
INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID;*/
            return con.cashout(query);
        }

       /* public object updatetable(object dt)
        {
            con.updatetable(dt);
        }*/

        public void updaterec(Products pd,int total)
        {
           // UPDATE Customer SET due = "+total+" + due WHERE cususername = (select cususername from Orders where Id = @val)
            string query = "Update Product set quantity = quantity - " + pd.quantity + " where productid = " + pd.productid + ";";
           // string query2 = "Update Orders set total = (SELECT sum(price * quantity) AS Value FROM Chart  WHERE Id = @val)";
            con.updaterec(query);
           // con.updaterec2(query2);
        }
        public void updaterec2()
        {
            string query2 = "Update Orders set total = (SELECT sum(price * quantity) AS Value FROM Chart  WHERE id = @val) where Id = @val";
           // con.updaterec(query);
            con.updaterec2(query2);
        }

        public System.Data.DataTable getspTable(Staff st)
        {
                          //  Select Id as [Order ID], cususername as [Customer Name], complete as Complete  from Orders where staffusername is NULL;
            string query = "Select Id as [Order ID], cususername as [Customer Name], complete as [Delivered]  from Orders where staffusername ='" + st.username + "' and taken = 1 and complete=0;";
            return con.getsptable(query);
        }

        public object stafflogin(Staff st)
        {
            string query = "Select * From Deliver where delusername = '" + st.username + "' and password = '" + st.password + "'";
            return con.stafflogin(query);
        }

        public void updatespo(Order od)
        {int tval=0,cval=0;
            //Update Orders set taken = 1 where id = 9;
        if (od.complete) cval = 1;
      
       
             string query = "Update Orders set complete = " + cval +  "  where Id = " + od.Id + ";";
            con.updaterec(query);

        }

        public System.Data.DataTable getsptakenTable(Staff st)
        {
             //string query = "Select Id as [Order ID], cususername as [Customer Name], taken as [Take Order]  from Orders where staffusername is NULL and taken = 0";
           
             string query = "Select Id as [Order ID], cususername as [Customer Name],complete as [Delivered] from Orders where staffusername = '"+st.username+"' and taken =1;";
            return con.getsptakenTable(query);
        }

        public object getsphistoryTable(Staff st)
        {
            string query = "Select Id as [Order ID], cususername as [Customer Name] from Orders where staffusername = '" + st.username + "' and complete = 1;";
           return con.getsptakenTable(query);
        }

       
        public void updatedsp(Order od)
        {
            int tval = 0, cval = 0;
            //Update Orders set taken = 1 where id = 9;
            
            if (od.complete) cval = 1;
            string query = "Update Orders set complete = " + cval + "  where Id = " + od.Id + ";";
           con.updatedsp(query);
        }

        public System.Data.DataTable gettekkentable(Staff st)
        {
            string query = "select Id, cususername as [Customername],complete as [Delivered] from Orders where staffusername = '" + st.username + "' and taken = 1;";
           return con.gettekkentable(query);
        }

        public object historytable(Staff st)
        {
            string query = "Select Id as [Order ID], cususername as [Customer Name] from Orders where staffusername = '" + st.username + "' and complete = 1;";
            return con.getsptakenTable(query);
        }

        public void perup(Order od)
        {
            string query = "Update Customer set due =  due -  (SELECT sum(price * quantity) AS Value FROM Chart  WHERE Id = "+od.Id+") where cususername = '" + od.cususername + "';";
           con.perup(query);
        }

        public System.Data.DataTable gettrtable(user us)
        {
            string query = "Select Id as [Order ID], taken as [Pending], complete as [Delivered], total as [Total Price] from  Orders where cususername = '"+us.username+"' and total >0";
            return con.gettable(query);
        }

        public System.Data.DataTable getnttable()
        {
            string query = "Select Id as [Order ID], cususername as [Customer Name], taken as [Take], total as [Total Price] from  Orders where taken = 0 and total >0";
            return con.gettable(query);
        }

        public void updatent(Order od)
        {
            if (od.taken == true)
            {
                string query = "Update Orders set taken = 1, staffusername='" + od.staffusername + "' WHERE Id = " + od.Id + ";";
                con.perup(query);
            }
        }
    }
}
