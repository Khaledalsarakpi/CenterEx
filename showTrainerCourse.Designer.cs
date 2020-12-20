namespace TrainingCenter
{
    partial class showTrainerCourse
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
            this.showdata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelnametrainer = new System.Windows.Forms.Label();
            this.lblidcard = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showdata)).BeginInit();
            this.SuspendLayout();
            // 
            // showdata
            // 
            this.showdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdata.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showdata.Location = new System.Drawing.Point(0, 114);
            this.showdata.Name = "showdata";
            this.showdata.RowHeadersWidth = 51;
            this.showdata.RowTemplate.Height = 24;
            this.showdata.Size = new System.Drawing.Size(975, 239);
            this.showdata.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(909, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المدرب";
            // 
            // labelnametrainer
            // 
            this.labelnametrainer.AutoSize = true;
            this.labelnametrainer.Location = new System.Drawing.Point(830, 69);
            this.labelnametrainer.Name = "labelnametrainer";
            this.labelnametrainer.Size = new System.Drawing.Size(41, 17);
            this.labelnametrainer.TabIndex = 2;
            this.labelnametrainer.Text = "المدرب";
            // 
            // lblidcard
            // 
            this.lblidcard.AutoSize = true;
            this.lblidcard.Location = new System.Drawing.Point(821, 27);
            this.lblidcard.Name = "lblidcard";
            this.lblidcard.Size = new System.Drawing.Size(59, 17);
            this.lblidcard.TabIndex = 4;
            this.lblidcard.Text = "الرقم الذاتي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(916, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "الرقم الذاتي";
            // 
            // showTrainerCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 353);
            this.Controls.Add(this.lblidcard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelnametrainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showdata);
            this.Name = "showTrainerCourse";
            this.Text = "showTrainerCourse";
            ((System.ComponentModel.ISupportInitialize)(this.showdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView showdata;
        public System.Windows.Forms.Label labelnametrainer;
        public System.Windows.Forms.Label lblidcard;
    }
}