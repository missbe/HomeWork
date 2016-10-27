package cn.missbe.web.home.action;

import org.apache.struts2.ServletActionContext;

/**
 * Created by Administrator on 2016/10/27 0027.
 */
public class UserLoginAction {
    private String username;
    private String userpass;

    public String execute(){
        if(null==username ||null==userpass){
            setRequestAttribute("请输入用户名和密码");
        }
        if("admin".equals(username) && "admin".equals(userpass)){
            setRequestAttribute("^_^用户登录成功^_^");
        }else{
            setRequestAttribute("用户名或者密码错误");
        }
        return  "success";
    }
    private void setRequestAttribute(String message){
        ServletActionContext.getRequest().setAttribute("message",message);
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getUserpass() {
        return userpass;
    }

    public void setUserpass(String userpass) {
        this.userpass = userpass;
    }
}
