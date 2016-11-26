namespace Home_Five
{
    partial class UserForm
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
            this.gridViewUser = new System.Windows.Forms.DataGridView();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textXueHao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboxSex = new System.Windows.Forms.ComboBox();
            this.comboFlag = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewUser
            // 
            this.gridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewUser.Location = new System.Drawing.Point(3, 12);
            this.gridViewUser.Name = "gridViewUser";
            this.gridViewUser.RowTemplate.Height = 23;
            this.gridViewUser.Size = new System.Drawing.Size(754, 169);
            this.gridViewUser.TabIndex = 0;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(162, 216);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 21);
            this.textName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(406, 307);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 21);
            this.textAge.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "年龄：";
            // 
            // textClass
            // 
            this.textClass.Location = new System.Drawing.Point(162, 301);
            this.textClass.Name = "textClass";
            this.textClass.Size = new System.Drawing.Size(100, 21);
            this.textClass.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "班级：";
            // 
            // textXueHao
            // 
            this.textXueHao.Location = new System.Drawing.Point(406, 216);
            this.textXueHao.Name = "textXueHao";
            this.textXueHao.Size = new System.Drawing.Size(100, 21);
            this.textXueHao.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "学号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "权限：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboxSex
            // 
            this.comboxSex.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboxSex.FormattingEnabled = true;
            this.comboxSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboxSex.Location = new System.Drawing.Point(406, 259);
            this.comboxSex.Name = "comboxSex";
            this.comboxSex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboxSex.Size = new System.Drawing.Size(100, 21);
            this.comboxSex.TabIndex = 5;
            // 
            // comboFlag
            // 
            this.comboFlag.FormattingEnabled = true;
            this.comboFlag.Items.AddRange(new object[] {
            "超级管理员",
            "普通管理员"});
            this.comboFlag.Location = new System.Drawing.Point(162, 263);
            this.comboFlag.Name = "comboFlag";
            this.comboFlag.Size = new System.Drawing.Size(100, 20);
            this.comboFlag.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "编辑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(543, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "更新";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 373);
            this.Controls.Add(this.comboFlag);
            this.Controls.Add(this.comboxSex);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textXueHao);
            this.Controls.Add(this.textClass);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.gridViewUser);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewUser;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textXueHao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboxSex;
        private System.Windows.Forms.ComboBox comboFlag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}