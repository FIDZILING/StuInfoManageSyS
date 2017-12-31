namespace StuInfoMaSys.Scholarship
{
    partial class AddScholInfoForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddScholInfobutton = new System.Windows.Forms.Button();
            this.Returnbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StuNotextBox = new System.Windows.Forms.TextBox();
            this.LevelcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TypecomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // AddScholInfobutton
            // 
            this.AddScholInfobutton.Location = new System.Drawing.Point(139, 292);
            this.AddScholInfobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddScholInfobutton.Name = "AddScholInfobutton";
            this.AddScholInfobutton.Size = new System.Drawing.Size(156, 32);
            this.AddScholInfobutton.TabIndex = 4;
            this.AddScholInfobutton.Text = "添加";
            this.AddScholInfobutton.UseVisualStyleBackColor = true;
            this.AddScholInfobutton.Click += new System.EventHandler(this.AddScholInfobutton_Click);
            // 
            // Returnbutton
            // 
            this.Returnbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Returnbutton.Location = new System.Drawing.Point(139, 366);
            this.Returnbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(156, 32);
            this.Returnbutton.TabIndex = 5;
            this.Returnbutton.Text = "返回";
            this.Returnbutton.UseVisualStyleBackColor = true;
            this.Returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "学         号：";
            // 
            // StuNotextBox
            // 
            this.StuNotextBox.Location = new System.Drawing.Point(129, 21);
            this.StuNotextBox.Name = "StuNotextBox";
            this.StuNotextBox.Size = new System.Drawing.Size(200, 27);
            this.StuNotextBox.TabIndex = 0;
            // 
            // LevelcomboBox
            // 
            this.LevelcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelcomboBox.FormattingEnabled = true;
            this.LevelcomboBox.Items.AddRange(new object[] {
            "无",
            "一等",
            "二等",
            "三等"});
            this.LevelcomboBox.Location = new System.Drawing.Point(129, 113);
            this.LevelcomboBox.Name = "LevelcomboBox";
            this.LevelcomboBox.Size = new System.Drawing.Size(200, 28);
            this.LevelcomboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "奖学金类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "奖学金等级：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "获 奖 日 期：";
            // 
            // TypecomboBox
            // 
            this.TypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypecomboBox.FormattingEnabled = true;
            this.TypecomboBox.Location = new System.Drawing.Point(129, 68);
            this.TypecomboBox.Name = "TypecomboBox";
            this.TypecomboBox.Size = new System.Drawing.Size(200, 28);
            this.TypecomboBox.TabIndex = 1;
            // 
            // AddScholInfoForm
            // 
            this.AcceptButton = this.AddScholInfobutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Returnbutton;
            this.ClientSize = new System.Drawing.Size(435, 477);
            this.Controls.Add(this.TypecomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LevelcomboBox);
            this.Controls.Add(this.StuNotextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Returnbutton);
            this.Controls.Add(this.AddScholInfobutton);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddScholInfoForm";
            this.ShowIcon = false;
            this.Text = "添加奖学金信息";
            this.Load += new System.EventHandler(this.AddScholInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AddScholInfobutton;
        private System.Windows.Forms.Button Returnbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StuNotextBox;
        private System.Windows.Forms.ComboBox LevelcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TypecomboBox;
    }
}