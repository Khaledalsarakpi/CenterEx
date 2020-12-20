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
    class TrainerMethod : classtable,IMethod
    {
        public Trainer trainer { get; set; }
       
        public TrainerMethod()
        {
           
            trainer = new Trainer();
            table = "Trainertb";
            field = "(idcard,name,qualification,phoneNumber,workplace,address)";
        }
        void IMethod.Add()
        {
            Dbhelper db = new Dbhelper();
            string com = $"insert into {table} {field}   values('{trainer.idcard}','{trainer.name}','{trainer.qualification}','{trainer.phoneNumber}','{trainer.workplace}','{trainer.address}')";
            db.commandExecuteNonQuery(com);
        }

        void IMethod.Delete(int id)
        {
            if (id != -1)
            {
                Dbhelper db = new Dbhelper();
                db.commandExecuteNonQuery($"delete from {table}  where id={id}");
            }
            else
            {
                Dbhelper db = new Dbhelper();
                db.commandExecuteNonQuery($"delete from {table} ");
            }
        }

        void IMethod.Update()
        {

            Dbhelper db = new Dbhelper();
            string com = $"update  {table} set idcard='{trainer.idcard}',name='{trainer.name}',qualification='{trainer.qualification}',phoneNumber='{trainer.phoneNumber}',workplace='{trainer.workplace}',address='{trainer.address}' where idcard='{trainer.idcard}'";
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
            db.dataReader($"select * from {table} where (idcard like '%{text}%' OR name like '%{text}%' OR qualification like '%{text}%' OR phoneNumber like '%{text}%' OR workplace like '%{text}%' OR address like '%{text}%')").Fill(data);
            return data;
            }
                
        }
    }

}