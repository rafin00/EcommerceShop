using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;
using System.Text.RegularExpressions;
using System.IO;

namespace Baccess
{
    public class Access
    {
       
      //  Connection con = new Connection();
        Cusdb db;
        public bool add(user us)
        {
            
           // string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            db = new Cusdb();
            return db.add(us);
            
            
        }
        public object login(user us)
        {
            db = new Cusdb();
            return db.login(us);
        }
        public bool adminlogin(admin ad)
        {
            db = new Cusdb();
            return db.adminlogin(ad);
        }
        public bool addproduct(Products pd)
        {
            db = new Cusdb();
           
                FileStream fs = new FileStream(pd.path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                pd.img= br.ReadBytes((int)fs.Length);
         
            return db.addproduct(pd);
        }


        public object search(Products pd)
        {
            db = new Cusdb();
            return db.serach(pd);
        }

        public bool updateproduct(Products pd)
        {
            db = new Cusdb();

            FileStream fs = new FileStream(pd.path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            pd.img = br.ReadBytes((int)fs.Length);

            return db.updateproduct(pd);
        }

        public bool deleteproduct(Products pd)
        {
            db = new Cusdb();
            return db.deleteproduct(pd); 
        }

        public bool addstaff(Staff st)
        {
            db = new Cusdb();
            return db.add(st);
        }

        public object search(Staff st)
        {
            db = new Cusdb();
            return db.serach(st);
        }

        public bool deletestaff(Staff st)
        {
            db = new Cusdb();
            return db.deletestaff(st); 
        }

        public bool updatestaff(Staff st)
        {
            db = new Cusdb();
            return db.updatestaff(st);
        }

        public System.Data.DataTable getTable()
        {
            //throw new NotImplementedException();
            db = new Cusdb();
            return db.gettable();
        
        }

        public System.Data.DataTable getuiTable()
        {
            db = new Cusdb();
            return db.getuitable();
        }

        public bool addtochart(Products pd,user us)
        {
            db = new Cusdb();
            return db.addtochart(pd,us);
        }

        public bool genorder(user us)
        {
            db = new Cusdb();
            return db.genorder(us);
        }

        public object gescTable()
        {
            db = new Cusdb();
            return db.getsctable();
        }

        public string gettotal()
        {
            db = new Cusdb();
            return db.gettotal();
        }

        public bool cashout(int total)
        {
            db = new Cusdb();
            return db.cashout(total);
        }

        
    
public void updaterec(Products pd,int total)
{
 	db= new Cusdb();
    db.updaterec(pd,total);
}

public System.Data.DataTable getspTable(Staff st)
{
    db = new Cusdb();
    return db.getspTable(st);
}

public object stafflogin(Staff st)
{
    db = new Cusdb();
    return db.stafflogin(st);
}

        public void updatespo(Order od)
             {
              db = new Cusdb();
                db.updatespo(od);
              }

        public System.Data.DataTable getsptakenTable(Staff st)
        {
            db = new Cusdb();
            return db.getsptakenTable(st);
        }

        public object getsphistoryTable(Staff st)
        {
            db = new Cusdb();
            return db.getsphistoryTable(st);
        }

        

        public void updatedsp(Order od)
        {
            db = new Cusdb();
            
             db.updatedsp(od);
        }

        public System.Data.DataTable getekkenTable(Staff st)
        {
            db = new Cusdb();
           return db.gettekkentable(st);
        }



        public object historyTable(Staff st)
        {
            db = new Cusdb();
            return db.historytable(st);
        }

        public void perup(Order od)
        {
            db = new Cusdb();
             db.perup(od);
        }

        public System.Data.DataTable gettrTable(user us)
        {
            db = new Cusdb(); return db.gettrtable(us);
        }

        public System.Data.DataTable getntTable()
        {
            db = new Cusdb(); return db.getnttable();
        }

        public void updatent(Order od)
        {
            db = new Cusdb();  db.updatent(od);
        }

        public void updaterec2()
        {
            db = new Cusdb(); db.updaterec2();
        }
    }
}
