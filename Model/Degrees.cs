using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCenter.Model
{
    class Degrees
    {
        public int id { get; set; }
        public double Dgpresence { set; get; }
        public double DgActivity { set; get; }
        public double Dgtest { set; get; }
        public int idTrainee { get; set; }
        public int idCourse { get; set; }

    }
}
