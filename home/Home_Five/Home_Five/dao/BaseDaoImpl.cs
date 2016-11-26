using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Home_Five.dao
{
    class BaseDaoImpl<T>:BaseDaoI<T>
    {
        private util.DBUtil db=new util.DBUtil();///初始一个连接对象

        public List<T> findAll()
        {
            //List<T> list = new List<T>();///保存查询出来的对象
            //string table =;
            //string sql = "select * from ";
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Modify(T t)
        {
            throw new NotImplementedException();
        }

        public bool Save(T t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T t)
        {
            throw new NotImplementedException();
        }
    }
}
