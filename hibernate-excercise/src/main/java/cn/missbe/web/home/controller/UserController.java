package cn.missbe.web.home.controller;

import cn.missbe.web.home.entity.UserBean;
import cn.missbe.web.home.service.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;

import java.util.List;

/**
 * Created by Administrator on 2016/10/28 0028.
 */
@Controller
@RequestMapping(value = "/user")
public class UserController {
    @Autowired
    private UserService service;

    @RequestMapping(value = "/")
    public String index(Model model){
//        List<UserBean> userList=service.getAllUser();
//        model.addAttribute("userList",userList);
        return "addUser";
    }
    @RequestMapping(value = "/list")
    public String list(Model model){
        List<UserBean> userList=service.getAllUser();
        model.addAttribute("userList",userList);
        return "listUser";
    }

    @RequestMapping(value = "/add")
    public String  addUser(UserBean user,Model model){
        System.out.println("addUser called!");
        if(null!=user && !user.getUsername().equals("")){
            service.save(user);
            model.addAttribute("message","用户已经成功添加了");
            return "redirect:/user/list";
        }else{
            System.out.println("user  is null!");
            model.addAttribute("message","用户添加失败了");
            return "addUser";
        }
    }

    @RequestMapping(value = "/delete/{id}")
    public String deleteUser(@PathVariable int id, Model model){
        UserBean user=new UserBean();
        user.setId(id);
        service.delete(user);
        return "redirect:/user/list";
    }

    @RequestMapping(value = "/update/{id}")
    public String updateUser(@PathVariable int id,Model model){
        UserBean user=new UserBean();
        user.setId(id);
        service.update(user);
        return "redirect:/user/list";
    }
}
