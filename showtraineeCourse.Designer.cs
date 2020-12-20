namespace TrainingCenter
{
    partial class showtraineeCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblidcard = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelnametrainer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showdata)).BeginInit();
            this.SuspendLayout();
            // 
            // lblidcard
            // 
            this.lblidcard.AutoSize = true;
            this.lblidcard.Location = new System.Drawing.Point(965, 5);
            this.lblidcard.Name = "lblidcard";
            this.lblidcard.Size = new System.Drawing.Size(59, 17);
            this.lblidcard.TabIndex = 9;
            this.lblidcard.Text = "الرقم الذاتي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1060, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "الرقم الذاتي";
            // 
            // labelnametrainer
            // 
            this.labelnametrainer.AutoSize = true;
            this.labelnametrainer.Location = new System.Drawing.Point(974, 47);
            this.labelnametrainer.Name = "labelnametrainer";
            this.labelnametrainer.Size = new System.Drawing.Size(41, 17);
            this.labelnametrainer.TabIndex = 7;
            this.labelnametrainer.Text = "المدرب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1053, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم المدرب";
            // 
            // showdata
            // 
            this.showdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdata.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showdata.Location = new System.Drawing.Point(0, 97);
            this.showdata.Name = "showdata";
            this.showdata.RowHeadersWidth = 51;
            this.showdata.RowTemplate.Height = 24;
            this.showdata.Size = new System.Drawing.Size(1126, 353);
            this.showdata.TabIndex = 5;
            this.showdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showdata_CellContentClick);
            // 
            // showtraineeCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 450);
            this.Controls.Add(this.lblidcard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelnametrainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showdata);
            this.Name = "showtraineeCourse";
            this.Text = "showtraineeCourse";
            ((System.ComponentModel.ISupportInitialize)(this.showdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblidcard;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelnametrainer;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView showdata;
    }
}