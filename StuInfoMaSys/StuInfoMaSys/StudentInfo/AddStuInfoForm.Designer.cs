namespace StuInfoMaSys.StudentInfo
{
    partial class AddStuInfoForm
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
            this.AddStuInfobutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StuNumtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.SexcomboBox = new System.Windows.Forms.ComboBox();
            this.SchoolTypecomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Returnbutton
            // 
            this.Returnbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Returnbutton.Location = new System.Drawing.Point(223, 336);
            this.Returnbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(112, 32);
            this.Returnbutton.TabIndex = 5;
            this.Returnbutton.Text = "返回";
            this.Returnbutton.UseVisualStyleBackColor = true;
            this.Returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
            // 
            // AddStuInfobutton
            // 
            this.AddStuInfobutton.Location = new System.Drawing.Point(72, 336);
            this.AddStuInfobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddStuInfobutton.Name = "AddStuInfobutton";
            this.AddStuInfobutton.Size = new System.Drawing.Size(112, 32);
            this.AddStuInfobutton.TabIndex = 4;
            this.AddStuInfobutton.Text = "添加";
            this.AddStuInfobutton.UseVisualStyleBackColor = true;
            this.AddStuInfobutton.Click += new System.EventHandler(this.AddStuInfobutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "学号：";
            // 
            // StuNumtextBox
            // 
            this.StuNumtextBox.Location = new System.Drawing.Point(203, 68);
            this.StuNumtextBox.Name = "StuNumtextBox";
            this.StuNumtextBox.Size = new System.Drawing.Size(121, 27);
            this.StuNumtextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "在校类别：";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(203, 124);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(121, 27);
            this.NametextBox.TabIndex = 1;
            // 
            // SexcomboBox
            // 
            this.SexcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexcomboBox.FormattingEnabled = true;
            this.SexcomboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.SexcomboBox.Location = new System.Drawing.Point(203, 176);
            this.SexcomboBox.Name = "SexcomboBox";
            this.SexcomboBox.Size = new System.Drawing.Size(121, 28);
            this.SexcomboBox.TabIndex = 2;
            // 
            // SchoolTypecomboBox
            // 
            this.SchoolTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SchoolTypecomboBox.FormattingEnabled = true;
            this.SchoolTypecomboBox.Items.AddRange(new object[] {
            "未到大一",
            "正常在校",
            "正常离校",
            "延期毕业",
            "休学",
            "退学"});
            this.SchoolTypecomboBox.Location = new System.Drawing.Point(203, 231);
            this.SchoolTypecomboBox.Name = "SchoolTypecomboBox";
            this.SchoolTypecomboBox.Size = new System.Drawing.Size(121, 28);
            this.SchoolTypecomboBox.TabIndex = 3;
            // 
            // AddStuInfoForm
            // 
            this.AcceptButton = this.AddStuInfobutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Returnbutton;
            this.ClientSize = new System.Drawing.Size(439, 461);
            this.Controls.Add(this.SchoolTypecomboBox);
            this.Controls.Add(this.SexcomboBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StuNumtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddStuInfobutton);
            this.Controls.Add(this.Returnbutton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddStuInfoForm";
            this.ShowIcon = false;
            this.Text = "添加本科生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Returnbutton;
        private System.Windows.Forms.Button AddStuInfobutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StuNumtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.ComboBox SexcomboBox;
        private System.Windows.Forms.ComboBox SchoolTypecomboBox;
    }
}