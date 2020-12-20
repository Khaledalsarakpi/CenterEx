using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCenter.Model;
using TrainingCenter.Database;
using System.Data;

namespace TrainingCenter.Controller
{
    class CourseMethod :classtable, IMethod
    {
        public Course course { get; set; }
        public CourseMethod()
        {
            course = new Course();
            table = "Coursetb";
            field = "(name,dateStart,hourseOfSet,state,idPlace,idTrainer)";
        }
        public void Add()
        {
            Dbhelper db = new Dbhelper();
            string com = $"insert into {table} {field}  values ('{course.name}','{course.dateStart}','{course.hourseOfSet}','{course.state}','{course.idPlace}','{course.idTrainer}')";
            db.commandExecuteNonQuery(com);
        }
        DataTable IMethod.search(string text,bool spc)
        {
            Dbhelper db = new Dbhelper();
            DataTable data = new DataTable();
            if (spc == true)
            {
                db.dataReader($"select {table}.id , {table}.name [اسم الدورة],dateStart [تاريخ البدء],hourseOfSet [عدد ساعات الجلسة],state [الحالة],TrPlace.name [القاعة] from {table} inner join TrPlace on idPlace=TrPlace.id  where idTrainer='{text}'").Fill(data);
                return data;
            }
            else
            {
                db.dataReader($" select dateStart from {table} where (dateStart like '%{text}%')").Fill(data);
                return data;
            }
        }
        public void Delete(int id)
        {
            Dbhelper db = new Dbhelper();
            string com = $"delete from {table} where id='{id}' ";
            db.commandExecuteNonQuery(com);
        }

        public void Update()
        {
            Dbhelper db = new Dbhelper();
            string com = $"update {table} set name={course.name},dateStart={course.dateStart},hourseOfSet={course.hourseOfSet},state={course.state},idPlace={course.idPlace},idTrainer={course.idTrainer} where id={course.id}";
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
