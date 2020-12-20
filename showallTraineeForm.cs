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
    public partial class showallTraineeForm : Form
    {
        public showallTraineeForm()
        {
            InitializeComponent();
        }
         
        private void showallTraineeForm_Load(object sender, EventArgs e)
        {
            IMethod m = new TraineeMethod();
            MessageBox.Show(m.getdata().Rows.Count.ToString());
            showtrainee.DataSource = m.getdata();
        }

        private void searchtextbox_TextChanged(object sender, EventArgs e)
        {
            IMethod m = new TraineeMethod();
            showtrainee.DataSource = m.search(searchtextbox.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == showtrainee.Columns["delete"].Index && e.RowIndex >= 0)
            {
                IMethod m = new TrainerMethod();
                m.Delete(int.Parse(showtrainee.CurrentRow.Cells["id"].Value.ToString()));
                showtrainee.Rows.RemoveAt(e.RowIndex);
            }
            else if (e.ColumnIndex == showtrainee.Columns["edite"].Index && e.RowIndex >= 0)
            {
                AddTraineeForm tr = new AddTraineeForm();
                tr.nameTextBox.Text = showtrainee.CurrentRow.Cells["name"].Value.ToString();
                tr.idcardTextBox.Text = showtrainee.CurrentRow.Cells["idcard"].Value.ToString();
                tr.phoneNumberTextBox.Text = showtrainee.CurrentRow.Cells["phoneNumber"].Value.ToString();
                tr.qualificationTextBox.Text = showtrainee.CurrentRow.Cells["qualification"].Value.ToString();
                tr.workplaceTextBox.Text = showtrainee.CurrentRow.Cells["workplace"].Value.ToString();
                tr.addressTextBox.Text = showtrainee.CurrentRow.Cells["address"].Value.ToString();
                tr.adjectivejopTextBox.Text= showtrainee.CurrentRow.Cells["adjectivejop"].Value.ToString();
               tr.idCourseComboBox.SelectedIndex=int.Parse(showtrainee.CurrentRow.Cells["idCourse"].Value.ToString());
                tr.btnadd.Text = "حفظ التغييرات";
                tr.btnadd.Name = "btnedite";
                tr.Show();
                tr.FormClosed += Tr_FormClosed; ;
            }
            else if (e.ColumnIndex == showtrainee.Columns["show"].Index && e.RowIndex >= 0)
            {
                showtraineeCourse trc = new showtraineeCourse();
                trc.labelnametrainer.Text = showtrainee.CurrentRow.Cells["name"].Value.ToString();
                trc.lblidcard.Text = showtrainee.CurrentRow.Cells["idcard"].Value.ToString();
                IMethod c = new TraineeMethod();
                trc.showdata.DataSource = c.search(showtrainee.CurrentRow.Cells["id"].Value.ToString(), true);
                trc.Show();
            }
        }

        private void Tr_FormClosed(object sender, FormClosedEventArgs e)
        {
            IMethod m = new TraineeMethod();
            showtrainee.DataSource = m.getdata();
        }
    }
}
