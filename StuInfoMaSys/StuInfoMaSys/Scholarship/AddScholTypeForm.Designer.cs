namespace StuInfoMaSys.Scholarship
{
    partial class AddScholTypeForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScholChar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Returnbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddScholTypebutton = new System.Windows.Forms.Button();
            this.ScholTypetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exportbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.ScholChar});
            this.dataGridView1.Location = new System.Drawing.Point(28, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(277, 494);
            this.dataGridView1.TabIndex = 2;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "ScholType";
            this.Type.HeaderText = "代码";
            this.Type.Name = "Type";
            // 
            // ScholChar
            // 
            this.ScholChar.DataPropertyName = "ScholChar";
            this.ScholChar.HeaderText = "奖学金名称";
            this.ScholChar.Name = "ScholChar";
            this.ScholChar.Width = 130;
            // 
            // Returnbutton
            // 
            this.Returnbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Returnbutton.Location = new System.Drawing.Point(418, 447);
            this.Returnbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(156, 32);
            this.Returnbutton.TabIndex = 1;
            this.Returnbutton.Text = "返回";
            this.Returnbutton.UseVisualStyleBackColor = true;
            this.Returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddScholTypebutton);
            this.groupBox1.Controls.Add(this.ScholTypetextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(374, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加奖学金类型";
            // 
            // AddScholTypebutton
            // 
            this.AddScholTypebutton.Location = new System.Drawing.Point(44, 126);
            this.AddScholTypebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddScholTypebutton.Name = "AddScholTypebutton";
            this.AddScholTypebutton.Size = new System.Drawing.Size(156, 32);
            this.AddScholTypebutton.TabIndex = 0;
            this.AddScholTypebutton.Text = "添加";
            this.AddScholTypebutton.UseVisualStyleBackColor = true;
            this.AddScholTypebutton.Click += new System.EventHandler(this.AddScholTypebutton_Click);
            // 
            // ScholTypetextBox
            // 
            this.ScholTypetextBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ScholTypetextBox.Location = new System.Drawing.Point(10, 65);
            this.ScholTypetextBox.Name = "ScholTypetextBox";
            this.ScholTypetextBox.Size = new System.Drawing.Size(223, 31);
            this.ScholTypetextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "要添加的奖学金类型：";
            // 
            // Exportbutton
            // 
            this.Exportbutton.Location = new System.Drawing.Point(442, 382);
            this.Exportbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exportbutton.Name = "Exportbutton";
            this.Exportbutton.Size = new System.Drawing.Size(112, 32);
            this.Exportbutton.TabIndex = 14;
            this.Exportbutton.Text = "导出";
            this.Exportbutton.UseVisualStyleBackColor = true;
            this.Exportbutton.Click += new System.EventHandler(this.Exportbutton_Click);
            // 
            // AddScholTypeForm
            // 
            this.AcceptButton = this.AddScholTypebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Returnbutton;
            this.ClientSize = new System.Drawing.Size(695, 573);
            this.Controls.Add(this.Exportbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Returnbutton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddScholTypeForm";
            this.ShowIcon = false;
            this.Text = "添加奖学金类别";
            this.Load += new System.EventHandler(this.AddScholTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Returnbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScholChar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddScholTypebutton;
        private System.Windows.Forms.TextBox ScholTypetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exportbutton;
    }
}