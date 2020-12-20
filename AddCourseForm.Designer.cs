namespace TrainingCenter
{
    partial class AddCourseForm
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
            System.Windows.Forms.Label hourseOfSetLabel;
            System.Windows.Forms.Label idPlaceLabel;
            System.Windows.Forms.Label dateStartLabel;
            System.Windows.Forms.Label idTrainerLabel;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.hourseOfSetTextBox = new System.Windows.Forms.TextBox();
            this.idPlaceComboBox = new System.Windows.Forms.ComboBox();
            this.dateStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTrainerComboBox = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            hourseOfSetLabel = new System.Windows.Forms.Label();
            idPlaceLabel = new System.Windows.Forms.Label();
            dateStartLabel = new System.Windows.Forms.Label();
            idTrainerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(569, 103);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(64, 17);
            nameLabel.TabIndex = 1;
            nameLabel.Text = ": اسم الدورة";
            nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // hourseOfSetLabel
            // 
            hourseOfSetLabel.AutoSize = true;
            hourseOfSetLabel.Location = new System.Drawing.Point(544, 238);
            hourseOfSetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hourseOfSetLabel.Name = "hourseOfSetLabel";
            hourseOfSetLabel.Size = new System.Drawing.Size(104, 17);
            hourseOfSetLabel.TabIndex = 5;
            hourseOfSetLabel.Text = ": عدد ساعات الجلسة";
            // 
            // idPlaceLabel
            // 
            idPlaceLabel.AutoSize = true;
            idPlaceLabel.Location = new System.Drawing.Point(583, 272);
            idPlaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idPlaceLabel.Name = "idPlaceLabel";
            idPlaceLabel.Size = new System.Drawing.Size(42, 17);
            idPlaceLabel.TabIndex = 7;
            idPlaceLabel.Text = ": القاعة";
            // 
            // dateStartLabel
            // 
            dateStartLabel.AutoSize = true;
            dateStartLabel.Location = new System.Drawing.Point(552, 193);
            dateStartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateStartLabel.Name = "dateStartLabel";
            dateStartLabel.Size = new System.Drawing.Size(90, 17);
            dateStartLabel.TabIndex = 8;
            dateStartLabel.Text = ": تاريخ بدء الدورة";
            // 
            // idTrainerLabel
            // 
            idTrainerLabel.AutoSize = true;
            idTrainerLabel.Location = new System.Drawing.Point(568, 144);
            idTrainerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idTrainerLabel.Name = "idTrainerLabel";
            idTrainerLabel.Size = new System.Drawing.Size(69, 17);
            idTrainerLabel.TabIndex = 9;
            idTrainerLabel.Text = ": اسم المدرب";
            idTrainerLabel.Click += new System.EventHandler(this.idTrainerLabel_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(139, 89);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(360, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // hourseOfSetTextBox
            // 
            this.hourseOfSetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "hourseOfSet", true));
            this.hourseOfSetTextBox.Location = new System.Drawing.Point(139, 223);
            this.hourseOfSetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hourseOfSetTextBox.Name = "hourseOfSetTextBox";
            this.hourseOfSetTextBox.Size = new System.Drawing.Size(360, 22);
            this.hourseOfSetTextBox.TabIndex = 6;
            // 
            // idPlaceComboBox
            // 
            this.idPlaceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "idPlace", true));
            this.idPlaceComboBox.FormattingEnabled = true;
            this.idPlaceComboBox.Location = new System.Drawing.Point(139, 267);
            this.idPlaceComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idPlaceComboBox.Name = "idPlaceComboBox";
            this.idPlaceComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.idPlaceComboBox.Size = new System.Drawing.Size(360, 24);
            this.idPlaceComboBox.TabIndex = 8;
            this.idPlaceComboBox.SelectionChangeCommitted += new System.EventHandler(this.idPlaceComboBox_SelectionChangeCommitted);
            this.idPlaceComboBox.Leave += new System.EventHandler(this.idPlaceComboBox_Leave);
            // 
            // dateStartDateTimePicker
            // 
            this.dateStartDateTimePicker.CustomFormat = "dd/mm/yyy";
            this.dateStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.courseBindingSource, "dateStart", true));
            this.dateStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStartDateTimePicker.Location = new System.Drawing.Point(139, 178);
            this.dateStartDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateStartDateTimePicker.Name = "dateStartDateTimePicker";
            this.dateStartDateTimePicker.Size = new System.Drawing.Size(360, 22);
            this.dateStartDateTimePicker.TabIndex = 9;
            this.dateStartDateTimePicker.ValueChanged += new System.EventHandler(this.dateStartDateTimePicker_ValueChanged);
            // 
            // idTrainerComboBox
            // 
            this.idTrainerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idTrainerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.idTrainerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "idTrainer", true));
            this.idTrainerComboBox.FormattingEnabled = true;
            this.idTrainerComboBox.Location = new System.Drawing.Point(139, 134);
            this.idTrainerComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTrainerComboBox.Name = "idTrainerComboBox";
            this.idTrainerComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.idTrainerComboBox.Size = new System.Drawing.Size(360, 24);
            this.idTrainerComboBox.TabIndex = 10;
            this.idTrainerComboBox.SelectionChangeCommitted += new System.EventHandler(this.idTrainerComboBox_SelectionChangeCommitted);
            this.idTrainerComboBox.Leave += new System.EventHandler(this.idTrainerComboBox_Leave);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(241, 326);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(153, 68);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "إضافة";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(TrainingCenter.Model.Course);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 455);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(idTrainerLabel);
            this.Controls.Add(this.idTrainerComboBox);
            this.Controls.Add(dateStartLabel);
            this.Controls.Add(this.dateStartDateTimePicker);
            this.Controls.Add(idPlaceLabel);
            this.Controls.Add(this.idPlaceComboBox);
            this.Controls.Add(hourseOfSetLabel);
            this.Controls.Add(this.hourseOfSetTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox hourseOfSetTextBox;
        private System.Windows.Forms.ComboBox idPlaceComboBox;
        private System.Windows.Forms.DateTimePicker dateStartDateTimePicker;
        private System.Windows.Forms.ComboBox idTrainerComboBox;
        private System.Windows.Forms.Button btnadd;
    }
}