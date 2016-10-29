package cn.missbe.web.test;

import cn.missbe.web.home.entity.UserBean;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.hibernate.boot.registry.StandardServiceRegistryBuilder;
import org.hibernate.cfg.Configuration;
import org.hibernate.service.ServiceRegistry;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

/**
 * Created by Administrator on 2016/10/29 0029.
 */
public class HibernateTest {
    private SessionFactory sessionFactory;
    private Session session;

    @Before
    public void init() {
        Configuration conf = new Configuration().configure();
        ServiceRegistry serviceReistry = new StandardServiceRegistryBuilder()
                .applySettings(conf.getProperties()).build();
        sessionFactory = conf.buildSessionFactory(serviceReistry);
        session = sessionFactory.openSession();
    }

    @Test
    public void testHibernate() {
//        // A SessionFactory is set up once for an application!
//        final StandardServiceRegistry registry = new StandardServiceRegistryBuilder()
//                .configure() // configures settings from hibernate.cfg.xml
//                .build();
//        SessionFactory sessionFactory=null;
//        try {
//             sessionFactory = new MetadataSources(registry).buildMetadata().buildSessionFactory();
//        }
//        catch (Exception e) {
//            // The registry would be destroyed by the SessionFactory, but we had trouble building the SessionFactory
//            // so destroy it manually.
//            StandardServiceRegistryBuilder.destroy( registry );
//        }
//        Configuration conf=new Configuration().configure();
//        ServiceRegistry serviceReistry=new StandardServiceRegistryBuilder()
//                .applySettings(conf.getProperties()).build();
//        SessionFactory sessionFactory=conf.buildSessionFactory(serviceReistry);


//            Session session=sessionFactory.openSession();
        Transaction transaction = session.beginTransaction();
        UserBean user = new UserBean();
        user.setPassword("password");
        user.setUsername("username");
        user.setTruename("truename");
        session.save(user);
        transaction.commit();
        session.close();
        sessionFactory.close();


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
