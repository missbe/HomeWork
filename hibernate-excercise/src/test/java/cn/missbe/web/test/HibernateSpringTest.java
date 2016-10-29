package cn.missbe.web.test;

import cn.missbe.web.home.entity.UserBean;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

/**
 * Created by Administrator on 2016/10/29 0029.
 */
public class HibernateSpringTest {
    private SessionFactory sessionFactory;
    private Session session;

    @Before
    public void init() {
        ApplicationContext context = new ClassPathXmlApplicationContext("spring-beans.xml");
       if(context.getBean("sessionFactory") instanceof  SessionFactory){
           sessionFactory = (SessionFactory)context.getBean("sessionFactory");
           session = sessionFactory.openSession();
       }else{
           System.out.print("获取sessionFactory失败");
       }
    }

    @Test
    public void testHibernate() {
        Transaction transaction = session.beginTransaction();
        UserBean user = new UserBean();
        user.setPassword("password");
        user.setUsername("username");
        user.setTruename("truename");
        session.save(user);
        transaction.commit();
        System.out.println("保存成功...");
    }

    @After
    public void close() {
        if (null != session) {
            session.close();
        }
        if (null != sessionFactory) {
            sessionFactory.close();
        }
    }
}
