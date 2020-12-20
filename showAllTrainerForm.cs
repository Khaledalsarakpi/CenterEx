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
    public partial class showallTrainerForm : Form
    {
        public showallTrainerForm()
        {
            InitializeComponent();
        }
        IMethod m = new TrainerMethod();
        private void showAllTrainerForm_Load(object sender, EventArgs e)
        {
           
            dataTrainer.DataSource = m.getdata();
        }

        private void searchtextbox_TextChanged(object sender, EventArgs e)
        {
            IMethod m = new TrainerMethod();
            dataTrainer.DataSource = m.search(searchtextbox.Text);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataTrainer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataTrainer.Columns["delete"].Index && e.RowIndex >= 0)
            {
                IMethod m = new TrainerMethod();
                m.Delete(int.Parse(dataTrainer.CurrentRow.Cells["id"].Value.ToString()));
                dataTrainer.Rows.RemoveAt(e.RowIndex);
            }
            else if (e.ColumnIndex == dataTrainer.Columns["edite"].Index && e.RowIndex >= 0)
            {
                AddTrainerForm tr = new AddTrainerForm();
                tr.nameTextBox.Text = dataTrainer.CurrentRow.Cells["name"].Value.ToString();
                tr.idcardTextBox.Text = dataTrainer.CurrentRow.Cells["idcard"].Value.ToString();
                tr.phoneNumberTextBox.Text = dataTrainer.CurrentRow.Cells["phoneNumber"].Value.ToString();
                tr.qualificationTextBox.Text = dataTrainer.CurrentRow.Cells["qualification"].Value.ToString();
                tr.workplaceTextBox.Text = dataTrainer.CurrentRow.Cells["workplace"].Value.ToString();
                tr.addressTextBox.Text = dataTrainer.CurrentRow.Cells["address"].Value.ToString();
                tr.btnadd.Text = "حفظ التغييرات";
                tr.btnadd.Name = "btnedite";
                tr.Show();
                tr.FormClosed += Tr_FormClosed;
            }
            else if (e.ColumnIndex == dataTrainer.Columns["show"].Index && e.RowIndex >= 0)
            {
                showTrainerCourse trc = new showTrainerCourse();
                trc.labelnametrainer.Text = dataTrainer.CurrentRow.Cells["name"].Value.ToString();
                trc.lblidcard.Text = dataTrainer.CurrentRow.Cells["idcard"].Value.ToString();
                IMethod c = new CourseMethod();
                trc.showdata.DataSource = c.search(dataTrainer.CurrentRow.Cells["id"].Value.ToString(), true);
                trc.Show();
            }

        }

        private void Tr_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataTrainer.DataSource = m.getdata();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
