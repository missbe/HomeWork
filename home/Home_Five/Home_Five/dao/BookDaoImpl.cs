using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Home_Five.dao
{
    class BookDaoImpl : BaseDaoI<model.Book>
    {
        private util.DBUtil db = new util.DBUtil();///初始一个连接对象
        public List<model.Book> findAll()
        {
            List<model.Book> list = new List<model.Book>();///保存查询出来的对象           
            string sql = "select * from books";
            db.Command.CommandText = sql;
            SqlDataReader read = db.Command.ExecuteReader();
            while (read.Read())
            {
                model.Book book = new model.Book();
                book.Id = read.GetInt32(read.GetOrdinal("id"));
                book.Name = read.GetString(read.GetOrdinal("name"));
                book.Description = read.GetString(read.GetOrdinal("description"));
                book.Author = read.GetString(read.GetOrdinal("author"));
                list.Add(book);
            }
            read.Close();///用完关闭
            return list;
        }

        public model.Book Get(int id)
        {
            model.Book book = new model.Book();
            string sql = "select * from books where id=@id";
            db.Command.CommandText = sql;
            db.Command.Parameters.Clear();///清除上一次的@ID
            db.Command.Parameters.AddWithValue("@id", id);
            SqlDataReader read = db.Command.ExecuteReader();
            if (read.Read())
            {

                book.Id = read.GetInt32(read.GetOrdinal("id"));
                book.Name = read.GetString(read.GetOrdinal("name"));
                book.Author = read.GetString(read.GetOrdinal("author"));
                book.Description = read.GetString(read.GetOrdinal("description"));
            }
            read.Close();///用完关闭
            return book;
        }

        public bool Modify(model.Book t)
        {
            string sql = "update books set name=@name,author=@author,description=@description " +
                       " where id=@id";
            db.Command.CommandText = sql;
            db.Command.Parameters.Clear();///清除上一次的@
            db.Command.Parameters.AddWithValue("@name", t.Name);
            db.Command.Parameters.AddWithValue("@author", t.Author);
            db.Command.Parameters.AddWithValue("@description", t.Description);         
            db.Command.Parameters.AddWithValue("@id", t.Id);
            int flag = db.Command.ExecuteNonQuery();

            return flag > 0 ? true : false;
        }

        public bool Save(model.Book t)
        {
           string sql = "insert into books(name,author,description) values(@name,@author,@description)";
            db.Command.CommandText = sql;
            db.Command.Parameters.Clear();///清除上一次的@
            db.Command.Parameters.AddWithValue("@name", t.Name);
            db.Command.Parameters.AddWithValue("@author", t.Author);
            db.Command.Parameters.AddWithValue("@description", t.Description);         
            db.Command.Parameters.AddWithValue("@id", t.Id);
            int flag = db.Command.ExecuteNonQuery();

            return flag > 0 ? true : false;
        }

        public bool Delete(model.Book t)
        {
            string sql = "delete from books where id=@id";
            db.Command.CommandText = sql;
            db.Command.Parameters.Clear();///清除上一次的@
            db.Command.Parameters.AddWithValue("@id", t.Id);
            int flag = db.Command.ExecuteNonQuery();
            return flag > 0 ? true : false;
        }
    }
}
