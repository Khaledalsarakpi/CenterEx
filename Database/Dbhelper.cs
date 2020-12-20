using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace TrainingCenter.Database
{//Class For create database and connection
    class Dbhelper
    {
        public Dbhelper()
        {
            openDb();
        }
       ~ Dbhelper()
        {
            try
            {
                CloseDb();
            }
            catch { }
        }
      SQLiteConnection cn;
      SQLiteCommand cm;
        SQLiteDataAdapter db;
        static string DatabaseName = "DbTrainning.db";
        string path =Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),DatabaseName);
        public bool openDb()
        {
            
            if (File.Exists(path))
            {
                Connection(path);
                return true;
            }
            else
            {
                FirstCreate();
                string tb = Properties.Resources.Createtables;
                Connection(path); 
                cm = new SQLiteCommand(tb,cn);
                cm.ExecuteNonQuery();
                
            }
            return true;

        }

        public void commandExecuteNonQuery(string com)
        {
            openDb();
            cm = new SQLiteCommand(com, cn);
            cm.ExecuteNonQuery();
            CloseDb();
        }
        public SQLiteDataAdapter dataReader(string com)
        {
        
           db = new SQLiteDataAdapter(com, cn);

            return db;
        }
        public bool CloseDb()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
                return true;
            }
            else
                return false;

        }
        void FirstCreate()
        {
            SQLiteConnection.CreateFile(path);

        }
        void Connection(string path)
        {
            cn = new SQLiteConnection($"Data Source = {path}; Version = 3;");
            cn.Open();
        }
    }
}
