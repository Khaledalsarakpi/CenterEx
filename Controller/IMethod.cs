using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCenter.Controller
{
    interface IMethod
    {
        void Add();
        void Update();
        void Delete(int id=-1);
        DataTable getdata(int id=-1);
        DataTable search(string text,bool spic=false);
    }
}
