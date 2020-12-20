using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCenter.Database;
using TrainingCenter.Model;

namespace TrainingCenter.Controller
{
    class TrPlaceMethod :classtable, IMethod
    {
        public TrPlace trPlace { get; set; }
        public TrPlaceMethod()
        {
            trPlace = new TrPlace();
            table = "TrPlace";
           
        }
        
        void IMethod.Add()
        {
            Database.Dbhelper db = new Dbhelper();
            string com = $"insert into {table} (name) values('{trPlace.name}')";
            db.commandExecuteNonQuery(com);
        }

        void IMethod.Delete(int id)
        {
            Database.Dbhelper db = new Dbhelper();
            string com = $"delete from {table} where id='{trPlace.id}' ";
            db.commandExecuteNonQuery(com);
        }
        DataTable IMethod.search(string text, bool spc)
        {
            Dbhelper db = new Dbhelper();
            DataTable data = new DataTable();
            if(spc==true)
            {
                db.dataReader($"select id from {table} where (name like '%{text}%')").Fill(data);
                return data;
            }
            else
            {
                db.dataReader($"select * from {table} where (id like '%{text}%' OR name like '%{text}%')").Fill(data);
                return data;
            }
            
        }
        void IMethod.Update()
        {
            Database.Dbhelper db = new Dbhelper();
            string com = $"update  {table} set name={trPlace.name} ";
            db.commandExecuteNonQuery(com);
        }
        DataTable IMethod.getdata(int id)
        {
            Dbhelper db = new Dbhelper();
            DataTable data = new DataTable();
            if (id != -1)
                db.dataReader($"select * from {table} where idcard={id}").Fill(data);
            else
                db.dataReader($"select * from {table}").Fill(data);
            return data;

        }
    }
}
