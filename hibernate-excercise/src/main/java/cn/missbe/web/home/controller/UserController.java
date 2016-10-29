package cn.missbe.web.home.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

/**
 * Created by Administrator on 2016/10/28 0028.
 */
@Controller(value = "/user")
public class UserController {
    @RequestMapping(name = "/")
    public String index(Model model){
        return "indexUI";
    }
}
