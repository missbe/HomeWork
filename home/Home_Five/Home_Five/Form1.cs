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
    public partial class home_form : Form
    {
        public home_form()
        {
            InitializeComponent();            
            Application.Run(new login_form());
            //Home_Five.util.DBUtil db = new util.DBUtil();
            //if (db.isConnect())
            //{
            //    MessageBox.Show("连接成功！");
            //}
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
           // Application.Run(new UserForm());
            UserForm user = new UserForm();
            user.Show();
           // this.Dispose();   
           // this.Hide();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            book_form book = new book_form();
            book.Show();
        }
    }
}
