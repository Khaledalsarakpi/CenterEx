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
    public partial class AddPlaceForm : Form
    {
        public AddPlaceForm()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            IMethod m = new TrPlaceMethod()
            {
                trPlace = new Model.TrPlace
                {
                    name = nameTextBox.Text
                }

            };
            m.Add();
            nameTextBox.Clear();
        }
    }
}
