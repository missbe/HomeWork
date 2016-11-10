package cn.missbe.web.test;

import cn.missbe.web.home.dao.UserDao;
import cn.missbe.web.home.entity.UserBean;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;

import java.util.List;

/**
 * Created by Administrator on 2016/10/30 0030.
 */
@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration(locations= {
        "classpath:spring-beans.xml"})
public class UserBeanTest  {
    @Autowired
    private UserDao dao;

    @Test
    public void addUserTest(){
        UserBean user_one=new UserBean("missbe.com","missbe","lovett");
        UserBean user_two=new UserBean("missbe.cn","missbe","lovettcn");
        UserBean user_three=new UserBean("missbe.org","missbe","lovettorg");
        dao.save(user_one);
        dao.save(user_two);
        dao.save(user_three);
    }
    @Test
    public void getAllUserTest(){
        List<UserBean> userList=dao.getAllUser();
        for (UserBean user:userList) {
            System.out.println(user.getId()+":"+user.getPassword()+":"+user.getUsername());
        }
    }

    @Test
    public void updateTest(){
        UserBean user=new UserBean();
        user.setId(1);
        user.setUsername("zhnagke");
        dao.update(user);
        getAllUserTest();
    }

    @Test
    public void deleteTest(){
        UserBean user=new UserBean();
        user.setId(2);
        dao.delete(user);
        user.setId(1);
        dao.delete(user);
        getAllUserTest();
    }
}
