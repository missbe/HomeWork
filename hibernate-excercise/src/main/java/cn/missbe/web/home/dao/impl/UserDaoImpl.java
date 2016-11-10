package cn.missbe.web.home.dao.impl;

import cn.missbe.web.home.dao.UserDao;
import cn.missbe.web.home.entity.UserBean;
import org.hibernate.SessionFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Administrator on 2016/10/30 0030.
 */
@Repository
@Transactional
public class UserDaoImpl implements UserDao {
    @Autowired
    private SessionFactory sessionFactory;

    public UserBean save(UserBean user) {
        sessionFactory.getCurrentSession().save(user);
        return user;
    }

    public void delete(UserBean user) {
        sessionFactory.getCurrentSession().delete(user);
    }

    public void update(UserBean user) {
        sessionFactory.getCurrentSession().update(user);
    }
    public List<UserBean> getAllUser(){
        List<UserBean> userList=new ArrayList<UserBean>();
        String hql="select distinct u from UserBean u";
        userList=sessionFactory.getCurrentSession().createQuery(hql).list();
        return userList;
    }
}
