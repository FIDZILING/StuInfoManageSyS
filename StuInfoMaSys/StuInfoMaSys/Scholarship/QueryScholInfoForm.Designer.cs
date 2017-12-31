namespace StuInfoMaSys.Scholarship
{
    partial class QueryScholInfoForm
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
            this.Returnbutton = new System.Windows.Forms.Button();
            this.QueryScholInfobutton = new System.Windows.Forms.Button();
            this.AddScholInfobutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scholchar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schollevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ScholTypecomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StuNotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Returnbutton
            // 
            this.Returnbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Returnbutton.Location = new System.Drawing.Point(511, 484);
            this.Returnbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(156, 32);
            this.Returnbutton.TabIndex = 7;
            this.Returnbutton.Text = "返回";
            this.Returnbutton.UseVisualStyleBackColor = true;
            this.Returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
            // 
            // QueryScholInfobutton
            // 
            this.QueryScholInfobutton.Location = new System.Drawing.Point(494, 27);
            this.QueryScholInfobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QueryScholInfobutton.Name = "QueryScholInfobutton";
            this.QueryScholInfobutton.Size = new System.Drawing.Size(156, 32);
            this.QueryScholInfobutton.TabIndex = 6;
            this.QueryScholInfobutton.Text = "查询";
            this.QueryScholInfobutton.UseVisualStyleBackColor = true;
            this.QueryScholInfobutton.Click += new System.EventHandler(this.QueryScholInfobutton_Click);
            // 
            // AddScholInfobutton
            // 
            this.AddScholInfobutton.Location = new System.Drawing.Point(331, 484);
            this.AddScholInfobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddScholInfobutton.Name = "AddScholInfobutton";
            this.AddScholInfobutton.Size = new System.Drawing.Size(156, 32);
            this.AddScholInfobutton.TabIndex = 8;
            this.AddScholInfobutton.Text = "添加";
            this.AddScholInfobutton.UseVisualStyleBackColor = true;
            this.AddScholInfobutton.Click += new System.EventHandler(this.AddScholInfobutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.stdno,
            this.scholchar,
            this.schollevel,
            this.day});
            this.dataGridView1.Location = new System.Drawing.Point(17, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(667, 340);
            this.dataGridView1.TabIndex = 9;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "序号";
            this.id.Name = "id";
            // 
            // stdno
            // 
            this.stdno.DataPropertyName = "StdNo";
            this.stdno.HeaderText = "学号";
            this.stdno.Name = "stdno";
            // 
            // scholchar
            // 
            this.scholchar.DataPropertyName = "ScholChar";
            this.scholchar.HeaderText = "奖学金种类";
            this.scholchar.Name = "scholchar";
            this.scholchar.Width = 150;
            // 
            // schollevel
            // 
            this.schollevel.DataPropertyName = "ScholLevel";
            this.schollevel.HeaderText = "奖学金等级";
            this.schollevel.Name = "schollevel";
            this.schollevel.Width = 120;
            // 
            // day
            // 
            this.day.DataPropertyName = "Day";
            this.day.HeaderText = "获奖日期";
            this.day.Name = "day";
            this.day.Width = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ScholTypecomboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StuNotextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.QueryScholInfobutton);
            this.groupBox1.Location = new System.Drawing.Point(17, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // ScholTypecomboBox
            // 
            this.ScholTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScholTypecomboBox.FormattingEnabled = true;
            this.ScholTypecomboBox.Location = new System.Drawing.Point(197, 60);
            this.ScholTypecomboBox.Name = "ScholTypecomboBox";
            this.ScholTypecomboBox.Size = new System.Drawing.Size(144, 28);
            this.ScholTypecomboBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "奖学金类型：";
            // 
            // StuNotextBox
            // 
            this.StuNotextBox.Location = new System.Drawing.Point(197, 20);
            this.StuNotextBox.Name = "StuNotextBox";
            this.StuNotextBox.Size = new System.Drawing.Size(144, 27);
            this.StuNotextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "学号：";
            // 
            // QueryScholInfoForm
            // 
            this.AcceptButton = this.QueryScholInfobutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Returnbutton;
            this.ClientSize = new System.Drawing.Size(706, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddScholInfobutton);
            this.Controls.Add(this.Returnbutton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "QueryScholInfoForm";
            this.ShowIcon = false;
            this.Text = "查询奖学金信息";
            this.Load += new System.EventHandler(this.QueryScholInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Returnbutton;
        private System.Windows.Forms.Button QueryScholInfobutton;
        private System.Windows.Forms.Button AddScholInfobutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdno;
        private System.Windows.Forms.DataGridViewTextBoxColumn scholchar;
        private System.Windows.Forms.DataGridViewTextBoxColumn schollevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox StuNotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ScholTypecomboBox;
    }
}