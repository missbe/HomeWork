using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Five.dao
{
    interface BaseDaoI<T>
    {
        List<T> findAll();
        T Get(int id);
        bool Modify(T t);
        bool Save(T t);
        bool Delete(T t);
    }
}
