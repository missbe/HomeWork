package cn.missbe.web.home.dao;

import cn.missbe.web.home.entity.UserBean;

import java.util.List;

/**
 * Created by Administrator on 2016/10/30 0030.
 */
public interface UserDao {
    /**
     * 保存用户
     * @param user
     * @return
     */
    UserBean save(UserBean user);

    /**
     * 删除用户
     * @param user
     */
    void delete(UserBean user);

    /**
     * 更新用户
     * @param user
     */
    void update(UserBean user);
    /**
     * 获取所有用户
     */
    List<UserBean> getAllUser();
}
