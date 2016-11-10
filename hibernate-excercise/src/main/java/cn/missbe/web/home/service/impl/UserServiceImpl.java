package cn.missbe.web.home.service.impl;

import cn.missbe.web.home.dao.UserDao;
import cn.missbe.web.home.entity.UserBean;
import cn.missbe.web.home.service.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

/**
 * Created by Administrator on 2016/10/30 0030.
 */
@Service
public class UserServiceImpl implements UserService {
    @Autowired
    private UserDao dao;
    public void save(UserBean user) {
        dao.save(user);
    }

    public void delete(UserBean user) {
        dao.delete(user);
    }

    public void update(UserBean user) {
        dao.update(user);
    }
    public List<UserBean> getAllUser(){
        return dao.getAllUser();
    }
}
