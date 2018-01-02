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
            this.SuspendLayout();
            // 
            // Returnbutton
            // 
            this.Returnbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Returnbutton.Location = new System.Drawing.Point(562, 480);
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
            this.AlterStuInfobutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AlterStuInfobutton.Location = new System.Drawing.Point(432, 480);
            this.AlterStuInfobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AlterStuInfobutton.Name = "AlterStuInfobutton";
            this.AlterStuInfobutton.Size = new System.Drawing.Size(112, 32);
            this.AlterStuInfobutton.TabIndex = 8;
            this.AlterStuInfobutton.Text = "修改";
            this.AlterStuInfobutton.UseVisualStyleBackColor = true;
            // 
            // AlterStuInfoForm
            // 
            this.AcceptButton = this.AlterStuInfobutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Returnbutton;
            this.ClientSize = new System.Drawing.Size(949, 613);
            this.Controls.Add(this.AlterStuInfobutton);
            this.Controls.Add(this.Returnbutton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AlterStuInfoForm";
            this.ShowIcon = false;
            this.Text = "修改本科生信息";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Returnbutton;
        private System.Windows.Forms.Button AlterStuInfobutton;
    }
}