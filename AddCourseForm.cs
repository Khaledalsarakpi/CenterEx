using Devart.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingCenter.Controller;

namespace TrainingCenter
{
    public partial class AddCourseForm : Form
    {
        int selecttrainer, selectplace;
        public AddCourseForm()
        {
            InitializeComponent();
            IMethod c = new TrainerMethod();

            DataRow[] data = c.getdata().Select();

            var auto = new AutoCompleteStringCollection();
            auto.AddRange(data.Select(x => x.Field<string>("name")).ToArray());
            idTrainerComboBox.AutoCompleteCustomSource = auto;
            idTrainerComboBox.Items.AddRange(data.Select(x => x.Field<string>("name")).ToArray());
            IMethod c1 = new TrPlaceMethod();

            DataRow[] data1 = c1.getdata().Select();

            var auto1 = new AutoCompleteStringCollection();
            auto.AddRange(data1.Select(x => x.Field<string>("name")).ToArray());
            idPlaceComboBox.AutoCompleteCustomSource = auto;
            idPlaceComboBox.Items.AddRange(data1.Select(x => x.Field<string>("name")).ToArray());
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void dateStartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTrainerLabel_Click(object sender, EventArgs e)
        {

        }

        private void idPlaceComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IMethod m = new TrPlaceMethod();
            if (m.search(idPlaceComboBox.Text).Rows.Count > 0)
            {
                selectplace = int.Parse(m.search(idPlaceComboBox.Text, true).Rows[0].Field<Int64>("id").ToString());
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            IMethod m = new CourseMethod();
            if (m.search(dateStartDateTimePicker.ToString()).Rows.Count == 0)
            {
                IMethod m1 = new CourseMethod()
                {
                    course = new Model.Course
                    {
                        state ="مفتوحة",
                        name = nameTextBox.Text,
                        dateStart = dateStartDateTimePicker.Value.ToString(),
                        hourseOfSet = int.Parse(hourseOfSetTextBox.Text),
                        idPlace =selectplace,
                        idTrainer = selecttrainer
                    }

                };
                m1.Add();
            }
            else
            {
                MessageBox.Show("ERROR");
            }


        }

        private void idTrainerComboBox_Leave(object sender, EventArgs e)
        {
            IMethod m = new TrainerMethod();
            if (m.search(idTrainerComboBox.Text).Rows.Count > 0)
            {           }
            else
            {
                MessageBox.Show("error");
                idTrainerComboBox.SelectAll();
                idTrainerComboBox.Focus();
            }
        }

        private void idPlaceComboBox_Leave(object sender, EventArgs e)
        {
            IMethod m = new TrPlaceMethod();
            if (m.search(idPlaceComboBox.Text).Rows.Count > 0)
            {
            }
            else
            {
                MessageBox.Show("error");
                idPlaceComboBox.SelectAll();
                idPlaceComboBox.Focus();
            }
        }

        private void idTrainerComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {        IMethod m = new TrainerMethod();
           if( m.search(idTrainerComboBox.Text).Rows.Count>0)
            {
                selecttrainer =(int)m.search(idTrainerComboBox.Text,true).Rows[0].Field<Int64>("id");
            }
           
        }
    }
}

