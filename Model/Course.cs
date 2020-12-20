
using DevExpress.Utils.Win;
using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCenter.Model
{
    class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public string dateStart { get; set; }
        public  int hourseOfSet { get; set; }
        public string  state { get; set; }
        public int idPlace { get; set; }
        public int idTrainer { get; set; }
       

    }


   
}
