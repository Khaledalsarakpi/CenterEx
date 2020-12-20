namespace TrainingCenter
{
    partial class AddTrainerForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label idcardLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label workplaceLabel;
            System.Windows.Forms.Label qualificationLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            this.btnclose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnadd = new System.Windows.Forms.Button();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.traineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationTextBox = new System.Windows.Forms.TextBox();
            this.workplaceTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.idcardTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            idcardLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            workplaceLabel = new System.Windows.Forms.Label();
            qualificationLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(468, 81);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(102, 26);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "اسم المدرب";
            // 
            // idcardLabel
            // 
            idcardLabel.AutoSize = true;
            idcardLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idcardLabel.Location = new System.Drawing.Point(477, 121);
            idcardLabel.Name = "idcardLabel";
            idcardLabel.Size = new System.Drawing.Size(100, 26);
            idcardLabel.TabIndex = 19;
            idcardLabel.Text = "الرقم الذاتي";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(509, 160);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(68, 26);
            addressLabel.TabIndex = 21;
            addressLabel.Text = "العنوان";
            // 
            // workplaceLabel
            // 
            workplaceLabel.AutoSize = true;
            workplaceLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            workplaceLabel.Location = new System.Drawing.Point(520, 201);
            workplaceLabel.Name = "workplaceLabel";
            workplaceLabel.Size = new System.Drawing.Size(57, 26);
            workplaceLabel.TabIndex = 23;
            workplaceLabel.Text = "الجهة";
            // 
            // qualificationLabel
            // 
            qualificationLabel.AutoSize = true;
            qualificationLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qualificationLabel.Location = new System.Drawing.Point(455, 247);
            qualificationLabel.Name = "qualificationLabel";
            qualificationLabel.Size = new System.Drawing.Size(122, 26);
            qualificationLabel.TabIndex = 27;
            qualificationLabel.Text = "المؤهل العلمي";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneNumberLabel.Location = new System.Drawing.Point(469, 288);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(108, 26);
            phoneNumberLabel.TabIndex = 29;
            phoneNumberLabel.Text = "رقم التواصل";
            // 
            // btnclose
            // 
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = global::TrainingCenter.Properties.Resources.icons8_cancel;
            this.btnclose.Location = new System.Drawing.Point(562, 0);
            this.btnclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(33, 30);
            this.btnclose.TabIndex = 34;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.btnclose);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnadd);
            this.splitContainer1.Panel2.Controls.Add(phoneNumberLabel);
            this.splitContainer1.Panel2.Controls.Add(this.phoneNumberTextBox);
            this.splitContainer1.Panel2.Controls.Add(qualificationLabel);
            this.splitContainer1.Panel2.Controls.Add(this.qualificationTextBox);
            this.splitContainer1.Panel2.Controls.Add(workplaceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.workplaceTextBox);
            this.splitContainer1.Panel2.Controls.Add(addressLabel);
            this.splitContainer1.Panel2.Controls.Add(this.addressTextBox);
            this.splitContainer1.Panel2.Controls.Add(idcardLabel);
            this.splitContainer1.Panel2.Controls.Add(this.idcardTextBox);
            this.splitContainer1.Panel2.Controls.Add(nameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.nameTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(595, 508);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(164, 348);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(171, 60);
            this.btnadd.TabIndex = 33;
            this.btnadd.Text = "إضافة";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "phoneNumber", true));
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(37, 283);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(364, 34);
            this.phoneNumberTextBox.TabIndex = 30;
            // 
            // traineeBindingSource
            // 
            this.traineeBindingSource.DataSource = typeof(TrainingCenter.Model.Trainee);
            // 
            // qualificationTextBox
            // 
            this.qualificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "qualification", true));
            this.qualificationTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualificationTextBox.Location = new System.Drawing.Point(37, 242);
            this.qualificationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qualificationTextBox.Name = "qualificationTextBox";
            this.qualificationTextBox.Size = new System.Drawing.Size(364, 34);
            this.qualificationTextBox.TabIndex = 28;
            // 
            // workplaceTextBox
            // 
            this.workplaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "workplace", true));
            this.workplaceTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workplaceTextBox.Location = new System.Drawing.Point(37, 196);
            this.workplaceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workplaceTextBox.Name = "workplaceTextBox";
            this.workplaceTextBox.Size = new System.Drawing.Size(364, 34);
            this.workplaceTextBox.TabIndex = 24;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(37, 155);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(364, 34);
            this.addressTextBox.TabIndex = 22;
            // 
            // idcardTextBox
            // 
            this.idcardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "idcard", true));
            this.idcardTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idcardTextBox.Location = new System.Drawing.Point(37, 114);
            this.idcardTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idcardTextBox.Name = "idcardTextBox";
            this.idcardTextBox.Size = new System.Drawing.Size(364, 34);
            this.idcardTextBox.TabIndex = 20;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(37, 76);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(364, 34);
            this.nameTextBox.TabIndex = 18;
            // 
            // AddTrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 508);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddTrainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTrainerForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource traineeBindingSource;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Button btnadd;
        public System.Windows.Forms.TextBox phoneNumberTextBox;
        public System.Windows.Forms.TextBox qualificationTextBox;
        public System.Windows.Forms.TextBox workplaceTextBox;
        public System.Windows.Forms.TextBox addressTextBox;
        public System.Windows.Forms.TextBox idcardTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
    }
}