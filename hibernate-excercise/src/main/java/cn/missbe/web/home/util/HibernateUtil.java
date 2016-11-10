package cn.missbe.web.home.util;

import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

/**
 * Created by Administrator on 2016/10/30 0030.
 */
public class HibernateUtil {
    public static final SessionFactory sessionFactory;

    static
    {
        ApplicationContext context = new ClassPathXmlApplicationContext("spring-beans.xml");
        sessionFactory = (SessionFactory)context.getBean("sessionFactory");
    }

    // ThreadLocal可以隔离多个线程的数据共享，因此不再需要对线程同步
    public static final ThreadLocal<Session> session
            = new ThreadLocal<Session>();

    public static Session currentSession()
            throws HibernateException
    {
        Session s = session.get();
        // 如果该线程还没有Session,则创建一个新的Session
        if (s == null)
        {
            s = sessionFactory.openSession();
            // 将获得的Session变量存储在ThreadLocal变量session里
            session.set(s);
        }
        return s;
    }

    public static void closeSession()
            throws HibernateException
    {
        Session s = session.get();
        if (s != null)
            s.close();
        session.set(null);
    }
}
