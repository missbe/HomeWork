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
    public partial class book_form : Form
    {
        private dao.BookDaoImpl bookDao = new dao.BookDaoImpl();
        private int idFlag;//编辑需要的ID

        public book_form()
        {
            InitializeComponent();
            List<model.Book> list = bookDao.findAll();
            showData(list);//显示数据
            buttonUpdate.Enabled = false;
            //textBoxId.Visible = false;
            //labelID.Visible = false;
        }
        //显示数据 
        private void showData(List<model.Book> list)
        {

            DataTable dt = new DataTable("tb_books");
            dt.Columns.Add("id", System.Type.GetType(" System.Int32"));
            dt.Columns.Add("name", System.Type.GetType("System.String"));
            dt.Columns.Add("author", System.Type.GetType("System.String"));            
            dt.Columns.Add("description", System.Type.GetType("System.String"));
            

            for (int i = 0; i < list.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["id"] = list[i].Id;
                dr["name"] = list[i].Name;
                dr["author"] = list[i].Author;
                dr["description"] = list[i].Description;              
               
                dt.Rows.Add(dr);
            }
            dataGridViewBooks.DataSource = dt;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string str = ((Button)sender).Text.Trim();
            if (str.Equals("添加"))
            {
                save("添加");//执行保存
            }
            else if (str.Equals("更新"))
            {
                save("更新");//执行更新
            }
            List<model.Book> list = bookDao.findAll();
            showData(list);
        }
        private void save(string str)
        {
            //int id = Int32.Parse(textBoxId.Text);
            string name = textBoxName.Text;
            string author = textBoxAuthor.Text;
            string description = textBoxDescription.Text;
            model.Book book = new model.Book( name, author, description);
             if (str.Equals("添加"))
            {
                bookDao.Save(book); //执行保存
            }
            else if (str.Equals("更新"))
            {
                if (null != dataGridViewBooks.CurrentRow.Cells[0].Value.ToString() &&
                    !dataGridViewBooks.CurrentRow.Cells[0].Value.ToString().Equals(""))
                {
                    //user.Id = Int32.Parse(gridViewUser.CurrentRow.Cells[0].Value.ToString());   
                    book.Id = idFlag;
                    bookDao.Modify(book);//执行更新
                    buttonUpdate.Enabled = false;
                }
                else
                {
                    MessageBox.Show("请选中你要更新的对象!");
                }             
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = true;

            string id = dataGridViewBooks.CurrentRow.Cells[0].Value.ToString();
            if (null != id && !id.Equals(""))
            {
                model.Book book = bookDao.Get(Int32.Parse(id));
                idFlag = book.Id;///保存ID
                ///
                FillText(book);
                ///刷新数据
                List<model.Book> list = bookDao.findAll();
                showData(list);
            }
            else
            {
                MessageBox.Show("请选中你要操作的对象!");
            }
        }

        private void FillText(model.Book book)
        {
            textBoxId.Text = "" + book.Id; ;
            textBoxName.Text=book.Name;
            textBoxAuthor.Text=book.Author;
            textBoxDescription.Text=book.Description;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ///获取操作对象标识
            // MessageBox.Show(gridViewUser.CurrentRow.Cells[0].Value.ToString());
            string id = dataGridViewBooks.CurrentRow.Cells[0].Value.ToString();
            if (null != id && !id.Equals(""))
            {
                model.Book book = new model.Book();
                book.Id = Int32.Parse(id);
                bookDao.Delete(book);
                ///刷新数据
                List<model.Book> list = bookDao.findAll();
                showData(list);
            }
            else
            {
                MessageBox.Show("请选中你要操作的对象!");
            }
        }

    }
}
