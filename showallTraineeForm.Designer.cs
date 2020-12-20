namespace TrainingCenter
{
    partial class showallTraineeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchtextbox = new System.Windows.Forms.TextBox();
            this.showtrainee = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.show = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.showtrainee)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtextbox
            // 
            this.searchtextbox.Location = new System.Drawing.Point(240, 0);
            this.searchtextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchtextbox.Multiline = true;
            this.searchtextbox.Name = "searchtextbox";
            this.searchtextbox.Size = new System.Drawing.Size(628, 42);
            this.searchtextbox.TabIndex = 3;
            this.searchtextbox.TextChanged += new System.EventHandler(this.searchtextbox_TextChanged);
            // 
            // showtrainee
            // 
            this.showtrainee.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showtrainee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.showtrainee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showtrainee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.edite,
            this.show});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showtrainee.DefaultCellStyle = dataGridViewCellStyle2;
            this.showtrainee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showtrainee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.showtrainee.Location = new System.Drawing.Point(0, 50);
            this.showtrainee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showtrainee.Name = "showtrainee";
            this.showtrainee.RowHeadersWidth = 51;
            this.showtrainee.RowTemplate.Height = 24;
            this.showtrainee.Size = new System.Drawing.Size(1068, 514);
            this.showtrainee.TabIndex = 2;
            this.showtrainee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // delete
            // 
            this.delete.HeaderText = "حذف";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Text = "حذف";
            this.delete.ToolTipText = "حذف";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 125;
            // 
            // edite
            // 
            this.edite.HeaderText = "تعديل";
            this.edite.MinimumWidth = 6;
            this.edite.Name = "edite";
            this.edite.Text = "تعديل";
            this.edite.ToolTipText = "تعديل";
            this.edite.UseColumnTextForButtonValue = true;
            this.edite.Width = 125;
            // 
            // show
            // 
            this.show.HeaderText = "عرض جميع الدورات المسجل بها";
            this.show.MinimumWidth = 6;
            this.show.Name = "show";
            this.show.Text = "عرض الدورات";
            this.show.ToolTipText = "عرض جميع الدورات المسجل بها";
            this.show.UseColumnTextForButtonValue = true;
            this.show.Width = 125;
            // 
            // showallTraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 564);
            this.Controls.Add(this.searchtextbox);
            this.Controls.Add(this.showtrainee);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "showallTraineeForm";
            this.Text = "showallTraineeForm";
            this.Load += new System.EventHandler(this.showallTraineeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showtrainee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchtextbox;
        private System.Windows.Forms.DataGridView showtrainee;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn edite;
        private System.Windows.Forms.DataGridViewButtonColumn show;
    }
}