namespace TrainingCenter
{
    partial class showallTrainerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataTrainer = new System.Windows.Forms.DataGridView();
            this.searchtextbox = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.show = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrainer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTrainer
            // 
            this.dataTrainer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTrainer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTrainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTrainer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.edite,
            this.show});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTrainer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTrainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataTrainer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataTrainer.Location = new System.Drawing.Point(0, 122);
            this.dataTrainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTrainer.Name = "dataTrainer";
            this.dataTrainer.RowHeadersWidth = 51;
            this.dataTrainer.RowTemplate.Height = 24;
            this.dataTrainer.Size = new System.Drawing.Size(1271, 514);
            this.dataTrainer.TabIndex = 0;
            this.dataTrainer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTrainer_CellClick);
            this.dataTrainer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchtextbox
            // 
            this.searchtextbox.Location = new System.Drawing.Point(280, 73);
            this.searchtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchtextbox.Multiline = true;
            this.searchtextbox.Name = "searchtextbox";
            this.searchtextbox.Size = new System.Drawing.Size(628, 42);
            this.searchtextbox.TabIndex = 1;
            this.searchtextbox.TextChanged += new System.EventHandler(this.searchtextbox_TextChanged);
            // 
            // delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.edite.ReadOnly = true;
            this.edite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edite.Text = "تعديل";
            this.edite.ToolTipText = "تعديل";
            this.edite.UseColumnTextForButtonValue = true;
            this.edite.Width = 125;
            // 
            // show
            // 
            this.show.HeaderText = "عرض الدورات التي يقوم بإعطائها";
            this.show.MinimumWidth = 6;
            this.show.Name = "show";
            this.show.ReadOnly = true;
            this.show.Text = "الدورات";
            this.show.ToolTipText = "عرض الدورا التي يقوم باعطائها هذا المدرب";
            this.show.UseColumnTextForButtonValue = true;
            this.show.Width = 125;
            // 
            // showAllTrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 636);
            this.Controls.Add(this.searchtextbox);
            this.Controls.Add(this.dataTrainer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "showAllTrainerForm";
            this.Text = "showAllTrainerForm";
            this.Load += new System.EventHandler(this.showAllTrainerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTrainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataTrainer;
        private System.Windows.Forms.TextBox searchtextbox;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn edite;
        private System.Windows.Forms.DataGridViewButtonColumn show;
    }
}