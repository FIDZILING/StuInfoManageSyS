namespace StuInfoMaSys.StudentInfo
{
    partial class AlterStuInfoForm
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
            this.AlterStuInfobutton = new System.Windows.Forms.Button();
            this.StuPergroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StuSchgroupBox = new System.Windows.Forms.GroupBox();
            this.StuFamgroupBox = new System.Windows.Forms.GroupBox();
            this.StuNoNameSexlabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StuPergroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Returnbutton
            // 
            this.Returnbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Returnbutton.Location = new System.Drawing.Point(795, 539);
            this.Returnbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(112, 32);
            this.Returnbutton.TabIndex = 7;
            this.Returnbutton.Text = "返回";
            this.Returnbutton.UseVisualStyleBackColor = true;
            this.Returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
            // 
            // AlterStuInfobutton
            // 
            this.AlterStuInfobutton.Location = new System.Drawing.Point(664, 539);
            this.AlterStuInfobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AlterStuInfobutton.Name = "AlterStuInfobutton";
            this.AlterStuInfobutton.Size = new System.Drawing.Size(112, 32);
            this.AlterStuInfobutton.TabIndex = 8;
            this.AlterStuInfobutton.Text = "修改";
            this.AlterStuInfobutton.UseVisualStyleBackColor = true;
            this.AlterStuInfobutton.Click += new System.EventHandler(this.AlterStuInfobutton_Click);
            // 
            // StuPergroupBox
            // 
            this.StuPergroupBox.Controls.Add(this.comboBox1);
            this.StuPergroupBox.Controls.Add(this.label2);
            this.StuPergroupBox.Controls.Add(this.dateTimePicker1);
            this.StuPergroupBox.Controls.Add(this.textBox1);
            this.StuPergroupBox.Location = new System.Drawing.Point(30, 53);
            this.StuPergroupBox.Name = "StuPergroupBox";
            this.StuPergroupBox.Size = new System.Drawing.Size(877, 151);
            this.StuPergroupBox.TabIndex = 9;
            this.StuPergroupBox.TabStop = false;
            this.StuPergroupBox.Text = "个人信息";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(401, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 0;
            // 
            // StuSchgroupBox
            // 
            this.StuSchgroupBox.Location = new System.Drawing.Point(30, 376);
            this.StuSchgroupBox.Name = "StuSchgroupBox";
            this.StuSchgroupBox.Size = new System.Drawing.Size(877, 139);
            this.StuSchgroupBox.TabIndex = 10;
            this.StuSchgroupBox.TabStop = false;
            this.StuSchgroupBox.Text = "在校信息";
            // 
            // StuFamgroupBox
            // 
            this.StuFamgroupBox.Location = new System.Drawing.Point(30, 210);
            this.StuFamgroupBox.Name = "StuFamgroupBox";
            this.StuFamgroupBox.Size = new System.Drawing.Size(877, 160);
            this.StuFamgroupBox.TabIndex = 10;
            this.StuFamgroupBox.TabStop = false;
            this.StuFamgroupBox.Text = "家庭信息";
            // 
            // StuNoNameSexlabel
            // 
            this.StuNoNameSexlabel.AutoSize = true;
            this.StuNoNameSexlabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuNoNameSexlabel.Location = new System.Drawing.Point(25, 23);
            this.StuNoNameSexlabel.Name = "StuNoNameSexlabel";
            this.StuNoNameSexlabel.Size = new System.Drawing.Size(72, 27);
            this.StuNoNameSexlabel.TabIndex = 1;
            this.StuNoNameSexlabel.Text = "学号：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "民族：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // AlterStuInfoForm
            // 
            this.AcceptButton = this.AlterStuInfobutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Returnbutton;
            this.ClientSize = new System.Drawing.Size(949, 613);
            this.Controls.Add(this.StuSchgroupBox);
            this.Controls.Add(this.StuNoNameSexlabel);
            this.Controls.Add(this.StuFamgroupBox);
            this.Controls.Add(this.StuPergroupBox);
            this.Controls.Add(this.AlterStuInfobutton);
            this.Controls.Add(this.Returnbutton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AlterStuInfoForm";
            this.ShowIcon = false;
            this.Text = "修改本科生信息";
            this.Load += new System.EventHandler(this.AlterStuInfoForm_Load);
            this.StuPergroupBox.ResumeLayout(false);
            this.StuPergroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Returnbutton;
        private System.Windows.Forms.Button AlterStuInfobutton;
        private System.Windows.Forms.GroupBox StuPergroupBox;
        private System.Windows.Forms.GroupBox StuSchgroupBox;
        private System.Windows.Forms.GroupBox StuFamgroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label StuNoNameSexlabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}