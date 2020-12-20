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
    class DegreesMethod :classtable, IMethod
    {
        public Degrees degrees { get; set; }
        public DegreesMethod()
        {
            degrees = new Degrees();
            table = "degresstb";
            field = "(Dgpresence,DgActivity,Dgtest,idTrainee,idCourse)";
        }
        DataTable IMethod.search(string text, bool spc)
        {
            Dbhelper db = new Dbhelper();
            DataTable data = new DataTable();

            db.dataReader($"select * from {table} where (idcard like '%{text}%' OR name like '%{text}%' OR qualification like '%{text}%' OR phoneNumber like '%{text}%' OR workplace like '%{text}%' OR address like '%{text}%')").Fill(data);
            return data;
        }
        public void Add()
        {
            Dbhelper db = new Dbhelper();
            string com = $"insert into  {table} {field} values({degrees.Dgpresence},{degrees.DgActivity},{degrees.Dgtest},{degrees.idTrainee},{degrees.idCourse})";
            db.commandExecuteNonQuery(com);
        }

        public void Delete(int id)
        {
            Dbhelper db = new Dbhelper();
            string com = $"delet from {table} where id={id} ";
            db.commandExecuteNonQuery(com);
        }

        public void Update()
        {
            Dbhelper db = new Dbhelper();
            string com = $"update {table} set Dgpresence= {degrees.Dgpresence},DgActivity={degrees.DgActivity},Dgtest={degrees.Dgtest},idTrainee={degrees.idTrainee},idCourse={degrees.idCourse} where id={degrees.id} ";
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
