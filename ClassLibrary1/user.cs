using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class user
    {
       /* public user(string username,string name,string address,string phone,string password)
        {
            this.username = username;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.password = password;
        }*/
        public void init(string username, string name, string address, string phone, string password)
        {
            this.username = username;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.password = password;
        }
       public string username, name, address,phone,password,email;
       public int due;
        
    }
}
