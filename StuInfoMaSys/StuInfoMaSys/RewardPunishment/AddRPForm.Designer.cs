namespace StuInfoMaSys.RewardPunishment
{
    partial class AddRPForm
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
            this.AddRPbutton = new System.Windows.Forms.Button();
            this.Returnbutton = new System.Windows.Forms.Button();
            this.InfotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RPTypecomboBox = new System.Windows.Forms.ComboBox();
            this.StuNumtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RPLevelcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddRPbutton
            // 
            this.AddRPbutton.Location = new System.Drawing.Point(53, 431);
            this.AddRPbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddRPbutton.Name = "AddRPbutton";
            this.AddRPbutton.Size = new System.Drawing.Size(112, 32);
            this.AddRPbutton.TabIndex = 5;
            this.AddRPbutton.Text = "添加";
            this.AddRPbutton.UseVisualStyleBackColor = true;
            this.AddRPbutton.Click += new System.EventHandler(this.AddRPbutton_Click);
            // 
            // Returnbutton
            // 
            this.Returnbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Returnbutton.Location = new System.Drawing.Point(219, 431);
            this.Returnbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(112, 32);
            this.Returnbutton.TabIndex = 6;
            this.Returnbutton.Text = "返回";
            this.Returnbutton.UseVisualStyleBackColor = true;
            this.Returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
            // 
            // InfotextBox
            // 
            this.InfotextBox.Location = new System.Drawing.Point(53, 258);
            this.InfotextBox.Multiline = true;
            this.InfotextBox.Name = "InfotextBox";
            this.InfotextBox.Size = new System.Drawing.Size(278, 166);
            this.InfotextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "学生学号：";
            // 
            // RPTypecomboBox
            // 
            this.RPTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RPTypecomboBox.FormattingEnabled = true;
            this.RPTypecomboBox.Location = new System.Drawing.Point(139, 88);
            this.RPTypecomboBox.Name = "RPTypecomboBox";
            this.RPTypecomboBox.Size = new System.Drawing.Size(192, 28);
            this.RPTypecomboBox.TabIndex = 1;
            this.RPTypecomboBox.SelectedIndexChanged += new System.EventHandler(this.RPTypecomboBox_SelectedIndexChanged);
            // 
            // StuNumtextBox
            // 
            this.StuNumtextBox.Location = new System.Drawing.Point(139, 32);
            this.StuNumtextBox.Name = "StuNumtextBox";
            this.StuNumtextBox.Size = new System.Drawing.Size(192, 27);
            this.StuNumtextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(49, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "奖惩等级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(49, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "奖惩类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(49, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "奖惩说明：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(49, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "奖惩日期：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // RPLevelcomboBox
            // 
            this.RPLevelcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RPLevelcomboBox.FormattingEnabled = true;
            this.RPLevelcomboBox.Location = new System.Drawing.Point(139, 138);
            this.RPLevelcomboBox.Name = "RPLevelcomboBox";
            this.RPLevelcomboBox.Size = new System.Drawing.Size(192, 28);
            this.RPLevelcomboBox.TabIndex = 2;
            // 
            // AddRPForm
            // 
            this.AcceptButton = this.AddRPbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Returnbutton;
            this.ClientSize = new System.Drawing.Size(400, 492);
            this.Controls.Add(this.RPLevelcomboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StuNumtextBox);
            this.Controls.Add(this.RPTypecomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfotextBox);
            this.Controls.Add(this.AddRPbutton);
            this.Controls.Add(this.Returnbutton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddRPForm";
            this.ShowIcon = false;
            this.Text = "添加奖惩信息";
            this.Load += new System.EventHandler(this.AddRPForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRPbutton;
        private System.Windows.Forms.Button Returnbutton;
        private System.Windows.Forms.TextBox InfotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RPTypecomboBox;
        private System.Windows.Forms.TextBox StuNumtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox RPLevelcomboBox;
    }
}