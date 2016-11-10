package cn.missbe.web.test;

import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.AbstractTransactionalJUnit4SpringContextTests;

/**
 * Created by Administrator on 2016/10/30 0030.
 */
@ContextConfiguration(locations= {
        "classpath:spring-beans.xml","classpath:spring-mvc.xml"})
public class BasicTest extends AbstractTransactionalJUnit4SpringContextTests {
}
