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
    public partial class AddTrainerForm : Form
    {
        public AddTrainerForm()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            if(btnadd.Name=="btnadd")
            {
                IMethod m = new TrainerMethod()
                {
                    trainer = new Trainer
                    {
                        name = setText(nameTextBox),
                        idcard = int.Parse(setText(idcardTextBox)),
                        address = setText(addressTextBox),
                        phoneNumber = setText(phoneNumberTextBox),
                        qualification = setText(qualificationTextBox),
                        workplace = setText(workplaceTextBox)
                    }
                };
                m.Add();
            }
           else if (btnadd.Name == "btnedite")
            {
                IMethod m = new TrainerMethod()
                {
                    trainer = new Trainer
                    {
                        name = setText(nameTextBox),
                        idcard = int.Parse(setText(idcardTextBox)),
                        address = setText(addressTextBox),
                        phoneNumber = setText(phoneNumberTextBox),
                        qualification = setText(qualificationTextBox),
                        workplace = setText(workplaceTextBox)
                    }
                };
                m.Update();
            }




            foreach (Control  item in splitContainer1.Panel2. Controls)
            {
                if(item is TextBox)
                {
                    (item as TextBox).Clear();
                }
            }
            this.Close();
        }



        string setText(TextBox text)
        {
            return text.Text;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
