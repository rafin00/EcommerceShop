using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Data
{
   public class Connection
    {//"E:\Study\Prog\C#\Project\E-shop_2\Cshpro\Data\Database1.mdf"
       SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\Xampp\htdocs\New folder\New folder\Data\Database1.mdf;Integrated Security=True");
       SqlDataAdapter sda;
       DataTable dt;
       SqlDataReader sdr;
        public Connection()
        { }
      
     
       public object login(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
           sdr = s.ExecuteReader();
           if (sdr.HasRows)
           {
               sdr.Read();
               //sdr = s.ExecuteReader();

               user us = new user();
               us.username = sdr["cususername"].ToString();
               us.name = sdr[1].ToString();
               us.email =sdr["email"].ToString();
               us.address = sdr["address"].ToString();
               us.phone = sdr["phone"].ToString();
               us.due = Convert.ToInt32(sdr["due"]);
               us.password=sdr["password"].ToString();
               con.Close();
               return us;
           }
           else
           {
               con.Close();
               return false;
           }

           dt= new DataTable();
           sda = new SqlDataAdapter(query, con);
           sda.Fill(dt);
           if (dt.Rows.Count == 1)
           {
               user us = new user();

               return true;
           }
           else 
               return false;
       }

       public bool adminlogin(string query)
       {
           dt = new DataTable();
           sda = new SqlDataAdapter(query, con);
           sda.Fill(dt);
           if (dt.Rows.Count == 1)
           {

               return true;
           }
           else
           {
               Console.WriteLine("kk");
               return false;

           }
       }

       public object search(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
           sdr = s.ExecuteReader();
           if (sdr.HasRows)
           {
               sdr.Read();
               //sdr = s.ExecuteReader();

               Products pd = new Products();
               if (sdr[1].ToString() == null)
               {
                   Console.WriteLine("NUll");
               }
               pd.name = sdr[1].ToString();
               pd.price = (int)sdr["price"];
               pd.quantity = (int)sdr["quantity"];
             //  pd.image = ObjectToByteArray(sdr["image"]);
               pd.img = (byte[])sdr["image"];
               pd.path = sdr["path"].ToString();
               con.Close();
               return pd;
           }
           else
           {
               con.Close();
               return false;
           }
       }

       byte[] ObjectToByteArray(object obj)
       {
           if (obj == null)
               return null;
           BinaryFormatter bf = new BinaryFormatter();
           using (MemoryStream ms = new MemoryStream())
           {
               bf.Serialize(ms, obj);
               return ms.ToArray();
           }
       }


       internal bool add(string query, byte[] img)
       {
          if(con.State!=ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
          // CommandBehavior.Parameters.Add(new SqlParameter("@img", img));
           s.Parameters.Add(new SqlParameter("@img", img));
           if (s.ExecuteNonQuery() == 1)
           {
               con.Close();
               return true;
           }
           else
           {
               con.Close();
               return false;
           }
       }

       internal bool add(string query)
       {
          // dt = new DataTable();
          // sda = new SqlDataAdapter(query, con);
           //sda.Fill(dt);
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query,con);
           if (s.ExecuteNonQuery() == 1)
           {
               con.Close();
               return true;
           }
           else
           {
               con.Close();
               Console.WriteLine("here"+dt.Rows.Count);
               return false;

           }
       }

       internal bool updateproduct(string query,byte[] img)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
           // CommandBehavior.Parameters.Add(new SqlParameter("@img", img));
           s.Parameters.Add(new SqlParameter("@img", img));
           if (s.ExecuteNonQuery() == 1)
           {
               con.Close();
               return true;
           }
           else
           {
               con.Close();
               return false;
           }
       }

       internal bool deleteproduct(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
           
           if (s.ExecuteNonQuery() == 1)
           {
               con.Close();
               return true;
           }
           else
           {
               con.Close();
               return false;
           }
       }

       internal object searchstaff(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
           sdr = s.ExecuteReader();
           if (sdr.HasRows)
           {
               sdr.Read();
               //sdr = s.ExecuteReader();

               Staff st = new Staff();
              
               st.name = sdr[1].ToString();
               st.phone = sdr["phone"].ToString();
               st.password = sdr["password"].ToString();
              

               con.Close();
               return st;
           }
           else
           {
               con.Close();
               return false;
           }
       }

       internal bool updatestaff(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
           
           if (s.ExecuteNonQuery() == 1)
           {
               con.Close();
               return true;
           }
           else
           {
               con.Close();
               return false;
           }
       }

       internal DataTable gettable(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s =new SqlCommand(query,con);
           SqlDataAdapter sda = new SqlDataAdapter();
           sda.SelectCommand = s;
           dt = new DataTable();
           sda.Fill(dt);
           con.Close();
           return dt;
           
           
           ///throw new NotImplementedException();
       }

       internal bool addtochart( string qchart)
       {
            if (con.State != ConnectionState.Open) con.Open();

            
                  SqlCommand  s = new SqlCommand(qchart,con);
                    s.Parameters.Add(new SqlParameter("@id",a));
                   
                    if (s.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    else return false;
                
       }
      static int a;
       internal bool genorder(string qorder, string qoid)
       {
           if (con.State != ConnectionState.Open) 
               con.Open();

            SqlCommand s = new SqlCommand(qorder,con);
            if (s.ExecuteNonQuery() == 1)
            {
                s = new SqlCommand(qoid, con);
                sdr = s.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Read();
                    a = Convert.ToInt32(sdr[0]);
                    sdr.Close();
                    return true;
                }
                else
                    return false;
            }
            else 
                return false;
       }

       internal object getsctable(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
           s.Parameters.Add(new SqlParameter("@val", a));
           SqlDataAdapter sda = new SqlDataAdapter();
           sda.SelectCommand = s;
           dt = new DataTable();
           sda.Fill(dt);
           con.Close();
           return dt;
           
       }

       internal string gettotal(string query)
       {
       if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query,con);
         s.Parameters.Add(new SqlParameter("@val", a));
           sdr = s.ExecuteReader();
           if (sdr.HasRows)
           {
               sdr.Read();
               return sdr[0].ToString();
           }
           else return "0";
       }

       internal bool cashout(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();

           SqlCommand s = new SqlCommand(query, con);
           s.Parameters.Add(new SqlParameter("@val", a));
               if(s.ExecuteNonQuery()==1)
               {
                   return true;
               }
               else return false;

       }

       internal void updatetable(object dt)
       {
           DataTable data = (DataTable)dt; 
       }

       internal void updaterec(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
           s.ExecuteNonQuery();
          
              
          
       }

       internal DataTable getsptable(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
          // s.Parameters.Add(new SqlParameter("@val", a));
           SqlDataAdapter sda = new SqlDataAdapter();
           sda.SelectCommand = s;
           dt = new DataTable();
           sda.Fill(dt);
           con.Close();
           return dt;
       }

       internal object stafflogin(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
           sdr = s.ExecuteReader();
           if (sdr.HasRows)
           {
               sdr.Read();
               //sdr = s.ExecuteReader();

              Staff st = new Staff();
               st.username = sdr["delusername"].ToString();
               st.name = sdr["name"].ToString();
               st.phone = sdr["phone"].ToString();
               
               st.password = sdr["password"].ToString();
               con.Close();
               return st;
           }
           else
           {
               con.Close();
               return false;
           }

           dt = new DataTable();
           sda = new SqlDataAdapter(query, con);
           sda.Fill(dt);
           if (dt.Rows.Count == 1)
           {
               user us = new user();

               return true;
           }
           else
               return false;
       }

       internal void updatespo(string query)
       {
           
       }

       internal DataTable getsptakenTable(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
           // s.Parameters.Add(new SqlParameter("@val", a));
           SqlDataAdapter sda = new SqlDataAdapter();
           sda.SelectCommand = s;
           dt = new DataTable();
           sda.Fill(dt);
           con.Close();
           return dt;
       }

       internal void updatedsp(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
           s.ExecuteNonQuery();
       }

       internal DataTable gettekkentable(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
           // s.Parameters.Add(new SqlParameter("@val", a));
           SqlDataAdapter sda = new SqlDataAdapter();
           sda.SelectCommand = s;
           dt = new DataTable();
           sda.Fill(dt);
           con.Close();
           return dt;
       }

       internal void perup(string query)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query, con);
           s.ExecuteNonQuery();
       }

       internal void updaterec2(string query2)
       {
           if (con.State != ConnectionState.Open) con.Open();
           SqlCommand s = new SqlCommand(query2, con);
           s.Parameters.Add(new SqlParameter("@val", a));
           s.ExecuteNonQuery();
       }
    }
}
