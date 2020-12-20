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
using TrainingCenter.Model;

namespace TrainingCenter
{
    public partial class AddTraineeForm : Form
    {
        int selected;
        public AddTraineeForm()
        {
            InitializeComponent();
            IMethod c = new CourseMethod();

           DataRow[] data = c.getdata().Select().Where(x => x.Field<string>("state") == "مفتوحة").ToArray();
            
                var auto = new AutoCompleteStringCollection();
            auto.AddRange(data.Select(x => x.Field<string>("name")).ToArray());
            idCourseComboBox.AutoCompleteCustomSource=auto;
            idCourseComboBox.Items.AddRange(data.Select(x => x.Field<string>("name")).ToArray());
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {


        }

        private void AddTraineeForm_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            IMethod add = new TraineeMethod()
            {
                trainee = new Trainee
                {
                    name = nameTextBox.Text,
                    idcard = int.Parse(idcardTextBox.Text),
                    Address = addressTextBox.Text,
                    Adjectivejop = adjectivejopTextBox.Text,
                    phoneNumber = phoneNumberTextBox.Text,
                    qualification = qualificationTextBox.Text,
                    workplace = workplaceTextBox.Text,
                    IdCourse = selected

                }
            };
            add.Add();
        }

        private void idCourseComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IMethod m = new CourseMethod();
            if (m.search(idCourseComboBox.Text).Rows.Count > 0)
            {
                
               
                selected = (int)m.search(idCourseComboBox.Text, true).Rows[0].Field<Int64>("id");
            }
        }
    }
}
