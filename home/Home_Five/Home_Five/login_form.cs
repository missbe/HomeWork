using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Home_Five
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void buttonSure_Click(object sender, EventArgs e)
        {
            if (!login())
            {
                message.Visible = true;
                message.Text = "用户名或密码不正确!";                
            }
            else
            {
                message.Visible = false;
                this.Dispose();
            }
        }
        private bool login()
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;
            dao.UserDaoImpl userDao = new dao.UserDaoImpl();
            ///执行登录操作
            return userDao.login(name, pass);
        }
    }
}
