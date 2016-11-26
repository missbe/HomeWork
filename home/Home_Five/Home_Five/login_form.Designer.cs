namespace Home_Five
{
    partial class login_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonOridnal = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonSure = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonOridnal);
            this.panel1.Controls.Add(this.radioButtonAdmin);
            this.panel1.Location = new System.Drawing.Point(167, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 23);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(20, 4);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(83, 16);
            this.radioButtonAdmin.TabIndex = 0;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "超级管理员";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButtonOridnal
            // 
            this.radioButtonOridnal.AutoSize = true;
            this.radioButtonOridnal.Location = new System.Drawing.Point(109, 4);
            this.radioButtonOridnal.Name = "radioButtonOridnal";
            this.radioButtonOridnal.Size = new System.Drawing.Size(83, 16);
            this.radioButtonOridnal.TabIndex = 1;
            this.radioButtonOridnal.TabStop = true;
            this.radioButtonOridnal.Text = "普通管理员";
            this.radioButtonOridnal.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.message);
            this.panel2.Controls.Add(this.buttonSure);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(79, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 134);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "密  码：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 21);
            this.textBox2.TabIndex = 1;
            // 
            // buttonSure
            // 
            this.buttonSure.Location = new System.Drawing.Point(211, 101);
            this.buttonSure.Name = "buttonSure";
            this.buttonSure.Size = new System.Drawing.Size(75, 30);
            this.buttonSure.TabIndex = 2;
            this.buttonSure.Text = "登录";
            this.buttonSure.UseVisualStyleBackColor = true;
            this.buttonSure.Click += new System.EventHandler(this.buttonSure_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文楷体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(92, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 63);
            this.label3.TabIndex = 2;
            this.label3.Text = "图书管理系统";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.ForeColor = System.Drawing.Color.Maroon;
            this.message.Location = new System.Drawing.Point(62, 90);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(47, 12);
            this.message.TabIndex = 3;
            this.message.Text = "message";
            this.message.Visible = false;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "login_form";
            this.Text = "图书管理系统";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonOridnal;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSure;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label message;
    }
}