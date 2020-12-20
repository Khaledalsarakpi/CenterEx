using DevExpress.Data.Helpers;
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
    class TraineeMethod :classtable, IMethod
    {
        public Trainee trainee { get; set; }
      
        public TraineeMethod()
        {
            trainee = new Trainee();
            table = "traineetb";
            field = " (idcard,name,qualification,phoneNumber,workplace,address,Adjectivejop,IdCourse)";
        }
        DataTable IMethod.search(string text, bool spc)
        {
            Dbhelper db = new Dbhelper();
            DataTable data = new DataTable();

            if(spc==true)
            {
                db.dataReader($"select * from {table} where (idcard like '%{text}%' OR name like '%{text}%' OR qualification like '%{text}%' OR phoneNumber like '%{text}%' OR workplace like '%{text}%' OR address like '%{text}%')").Fill(data);
                return data;
            }
            else
            {
 db.dataReader($"select * from {table} where (idcard like '%{text}%' OR name like '%{text}%' OR qualification like '%{text}%' OR phoneNumber like '%{text}%' OR workplace like '%{text}%' OR address like '%{text}%')").Fill(data);
            return data;
            }
           
        }
        void IMethod.Add()
        {
            Dbhelper db = new Dbhelper();
            string com = $"insert into {table} {field} values ('{trainee.idcard}','{trainee.name}','{trainee.qualification}','{trainee.phoneNumber}','{trainee.workplace}','{trainee.Address}','{trainee.Adjectivejop}','{trainee.IdCourse}')";
            db.commandExecuteNonQuery(com);
        }

        void IMethod.Delete(int id)
        {
            if(id!=-1)
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
            string com = $"update {table}  set idcard={trainee.idcard},name={trainee.name},qualification={trainee.qualification},phoneNumber={trainee.phoneNumber},workplace={trainee.workplace},address={trainee.Address},Adjectivejop{trainee.Adjectivejop},IdCourse={trainee.IdCourse} where id={trainee.id}";
            db.commandExecuteNonQuery(com);
        }

        DataTable IMethod.getdata( int id)
          {
           
            Dbhelper db = new Dbhelper();
            DataTable data = new DataTable();
            if(id!=-1)
            db.dataReader($"select idcard,{table}.name,qualification,phoneNumber,workplace,address,Adjectivejop,Coursetb.name  from {table} inner join Coursetb on Coursetb.id=IdCourse  where idcard={id}").Fill(data);
            else
                db.dataReader($"select idcard  [الرقم الذاتي],{table}.name [اسم المتدرب],qualification [المؤهل العلمي],phoneNumber [رقم التواصل],workplace [الجهة],address [العنوان],Adjectivejop [الصفة الاعتبارية],Coursetb.name [الدورة التدريبية]  from {table} inner join Coursetb on Coursetb.id=IdCourse").Fill(data);
            return data;
           
        }
    }
}
