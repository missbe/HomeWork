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
    public partial class UserForm : Form
    {
        private dao.UserDaoImpl userDao = new dao.UserDaoImpl();
        private int idFlag;//编辑需要的ID
        public UserForm()
        {
            InitializeComponent();            
            List<model.User> list = userDao.findAll();
            showData(list);//显示数据
            button4.Enabled = false;
        }
        //显示数据 
        private void showData(List<model.User> list)
        {                 

            DataTable dt = new DataTable("tb_admin");
            dt.Columns.Add("id", System.Type.GetType(" System.Int32"));
            dt.Columns.Add("name", System.Type.GetType("System.String"));
            dt.Columns.Add("num", System.Type.GetType("System.String"));
            dt.Columns.Add("sex", System.Type.GetType("System.String"));
            dt.Columns.Add("age", System.Type.GetType("System.Int32"));
            dt.Columns.Add("className", System.Type.GetType("System.String"));
            dt.Columns.Add("flag", System.Type.GetType("System.String"));

            for (int i = 0; i < list.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["id"] = list[i].Id;
                dr["name"] = list[i].Name;
                dr["sex"] = list[i].Sex == 1 ? "男" : "女";
                dr["flag"] = list[i].Flag == 1 ? "超级管理员" : "普通管理员";
                dr["age"] = list[i].Age;
                dr["num"] = list[i].Num;
                dr["className"] = list[i].ClassName;
                Console.WriteLine(list[i].Id + ":" + list[i].Name + ":" + list[i].ClassName);
                dt.Rows.Add(dr);
            }
            gridViewUser.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = ((Button)sender).Text.Trim();
            if (str.Equals("添加"))
            {
                save("添加");//执行保存
            }
            else if(str.Equals("更新"))
            {
                save("更新");//执行更新
            }
            List<model.User> list = userDao.findAll();
            showData(list);
        }
        private void save(string str)
        {
            string ageStr = textAge.Text.Trim().Equals("")
               ? "18" : textAge.Text;
            int age = Int32.Parse(ageStr);//解析成整型
            string name = textName.Text.Trim().Equals("")
                ? "默认" : textName.Text;
            string xuehao = textXueHao.Text.Trim().Equals("")
                ? "默认学号" : textXueHao.Text;
            string className = textClass.Text.Trim().Equals("")
                ? "默认班级" : textClass.Text;

            int flag = comboFlag.Text.Trim().Equals("超级管理员")
                ? 1 : 0;
            int sex = comboxSex.Text.Trim().Equals("男")
                ? 1 : 0;
            model.User user = new model.User(sex, age, flag, name, xuehao, className);

            if (str.Equals("添加"))
            {
                userDao.Save(user); //执行保存
            }
            else if (str.Equals("更新"))
            {
                if (null != gridViewUser.CurrentRow.Cells[0].Value.ToString() &&
                    !gridViewUser.CurrentRow.Cells[0].Value.ToString().Equals(""))
                {
                    //user.Id = Int32.Parse(gridViewUser.CurrentRow.Cells[0].Value.ToString());
                    user.Id = idFlag;
                    userDao.Modify(user);//执行更新
                    button4.Enabled = false;
                }
                else
                {
                    MessageBox.Show("请选中你要更新的对象!");
                }               
            }
           
        }
        //编辑
        private void button1_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;

            string id = gridViewUser.CurrentRow.Cells[0].Value.ToString();
            if (null != id && !id.Equals(""))
            {      
                model.User user=userDao.Get(Int32.Parse(id));
                idFlag = user.Id;///保存ID
                                 ///
                FillText(user);
                ///刷新数据
                List<model.User> list = userDao.findAll();
                showData(list);
            }
            else
            {
                MessageBox.Show("请选中你要操作的对象!");
            }
        }
        private void FillText(model.User user)
        {
            textAge.Text=""+user.Age;           
            textName.Text=user.Name;
            textXueHao.Text=user.Num;
            textClass.Text=user.ClassName;

            comboFlag.Text=user.Flag==1
                ? "超级管理员" : "普通管理员";
            comboxSex.Text=user.Sex==1
                ? "男" : "女";
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            ///获取操作对象标识
           // MessageBox.Show(gridViewUser.CurrentRow.Cells[0].Value.ToString());
            string id=gridViewUser.CurrentRow.Cells[0].Value.ToString();
            if (null != id && !id.Equals(""))
            {
                model.User user = new model.User();
                user.Id = Int32.Parse(id);
                userDao.Delete(user);
                ///刷新数据
                List<model.User> list = userDao.findAll();
                showData(list);
            }
            else
            {
                MessageBox.Show("请选中你要操作的对象!");
            }
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }       
    }
}
