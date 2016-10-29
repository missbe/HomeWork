package cn.missbe.web.home.entity;

import javax.persistence.*;

/**
 * Created by Administrator on 2016/10/28 0028.
 */
@Entity
@Table(name="tbl_user")
public class UserBean {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;
    private String username;
    private  String password;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getTruename() {
        return truename;
    }

    public void setTruename(String truename) {
        this.truename = truename;
    }

    private  String truename;

    public  UserBean(){}

    public UserBean(String username,String password,String truename){
        this.username=username;
        this.password=password;
        this.truename=truename;
    }
}
