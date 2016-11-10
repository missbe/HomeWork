package cn.missbe.web.test;

import cn.missbe.web.home.entity.Name;
import cn.missbe.web.home.entity.Person;
import cn.missbe.web.home.entity.Score;
import cn.missbe.web.home.entity.UserBean;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import java.util.HashMap;
import java.util.Map;

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
//    @Test
//    public void testPersonList(){
//        Transaction transaction=session.beginTransaction();
//        Person person=new Person();
//        person.setAge(40);
//        person.setName("missbe.com");
//        person.setHappenSeason(Person.Season.SUMMER);
//        person.getSchools().add("四川理工");
//        person.getSchools().add("成都大学");
//
//        session.save(person);
//        transaction.commit();
//    }
//    @Test
//    public void testName(){
//        Transaction transaction=session.beginTransaction();
//        Person person=new Person();
//        Name name=new Name("missbe.com","com");
//        person.setAge(40);
//        person.setName(name);
//        person.setHappenSeason(Person.Season.SUMMER);
//        person.getName().getPower().put("missbe",1314);
//        person.getName().getPower().put("missbe",520);
//
//        session.save(person);
//        transaction.commit();
//    }
    @Test
    public void testCollectionMap(){
        Transaction tx = session.beginTransaction();
        // 创建Person对象
        Person person = new Person();
        //为Person对象设置属性
        person.setAge(29);
        //创建一个Map集合
        Map<String , Name> nicks =
                new HashMap<String , Name>();
        // 向List集合里放入Name对象
        person.getNicks().add(new Name("Wawa" , "Wawa"));
        person.getNicks().add(new Name("Yeeku" , "Lee"));
        // 向List集合里放入Score对象
        person.getScores().put("语文" , new Score("良好" , 85));
        person.getScores().put("数学" , new Score("优秀" , 92));
        session.save(person);
        tx.commit();
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
