using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Home_Five.dao
{
    class UserDaoImpl:BaseDaoI<model.User>
    {
        private util.DBUtil db = new util.DBUtil();///初始一个连接对象
                                                   ///
        public List<model.User> findAll()
        {
            List<model.User> list = new List<model.User>();///保存查询出来的对象           
            string sql = "select * from admin";
            db.Command.CommandText = sql;
            SqlDataReader read = db.Command.ExecuteReader();
            while (read.Read())
            {
                model.User user = new model.User();
                user.Id = read.GetInt32(read.GetOrdinal("id"));
                user.Name = read.GetString(read.GetOrdinal("name"));
                user.Sex = read.GetInt32(read.GetOrdinal("sex"));
                user.Age = read.GetInt32(read.GetOrdinal("age"));
                user.Num = read.GetString(read.GetOrdinal("num"));
                user.Flag = read.GetInt32(read.GetOrdinal("flag"));
                user.ClassName = read.GetString(read.GetOrdinal("className"));
                list.Add(user);///添加
            }
            read.Close();///用完关闭
            return list;
        }

        public model.User Get(int id)
        {
            model.User user = new model.User();
            string sql = "select * from admin where id=@id";
            db.Command.CommandText = sql;
            db.Command.Parameters.Clear();///清除上一次的@ID
            db.Command.Parameters.AddWithValue("@id", id);
            SqlDataReader read = db.Command.ExecuteReader();

            if (read.Read())
            {
                
                user.Id = read.GetInt32(read.GetOrdinal("id"));
                user.Name = read.GetString(read.GetOrdinal("name"));
                user.Sex = read.GetInt32(read.GetOrdinal("sex"));
                user.Age = read.GetInt32(read.GetOrdinal("age"));
                user.Num = read.GetString(read.GetOrdinal("num"));
                user.Flag = read.GetInt32(read.GetOrdinal("flag"));
                user.ClassName = read.GetString(read.GetOrdinal("className"));               
            }
            read.Close();///用完关闭
            return user;
        }
        public bool login(string name, string pass)
        {
            string sql = "select count(*) from admin where name=@name and pass=@pass";
            db.Command.CommandText = sql;
            db.Command.Parameters.Clear();///清除上一次的@ID
            db.Command.Parameters.AddWithValue("@name", name);
            db.Command.Parameters.AddWithValue("@pass", pass);
            int count = (Int32)db.Command.ExecuteScalar();

            return count > 0 ? true : false;
        }

        public bool Modify(model.User t)
        {
            string sql = "update admin set name=@name,num=@num,sex=@sex,"
                           + " age=@age,className=@className,flag=@flag"
                           +" where id=@id ";
            db.Command.CommandText = sql;
            db.Command.Parameters.Clear();///清除上一次的@
            db.Command.Parameters.AddWithValue("@name", t.Name);
            db.Command.Parameters.AddWithValue("@num", t.Num);
            db.Command.Parameters.AddWithValue("@sex", t.Sex);
            db.Command.Parameters.AddWithValue("@age", t.Age);
            db.Command.Parameters.AddWithValue("@className", t.ClassName);
            db.Command.Parameters.AddWithValue("@flag", t.Flag);
            db.Command.Parameters.AddWithValue("@id", t.Id);
            int flag=db.Command.ExecuteNonQuery();
            return flag > 0 ? true : false;
        }

        public bool Save(model.User t)
        {
            string sql = "insert into admin(name,num,sex,age,className,flag)"
                         +" values(@name,@num,@sex,@age,@className,@flag)";
            db.Command.CommandText = sql;
            db.Command.Parameters.Clear();///清除上一次的@
            db.Command.Parameters.AddWithValue("@name", t.Name);
            db.Command.Parameters.AddWithValue("@num", t.Num);
            db.Command.Parameters.AddWithValue("@sex", t.Sex);
            db.Command.Parameters.AddWithValue("@age", t.Age);
            db.Command.Parameters.AddWithValue("@className", t.ClassName);
            db.Command.Parameters.AddWithValue("@flag", t.Flag);
            int flag = db.Command.ExecuteNonQuery();
            return flag > 0 ? true : false;
        }

        public bool Delete(model.User t)
        {
            string sql = "delete from admin where id=@id";
            db.Command.CommandText = sql;
            db.Command.Parameters.Clear();///清除上一次的@
            db.Command.Parameters.AddWithValue("@id", t.Id);            
            int flag = db.Command.ExecuteNonQuery();
            return flag > 0 ? true : false;
        }
    }
}
