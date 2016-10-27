<%@ page language="java" contentType="text/html; charset=UTF-8"
         pageEncoding="UTF-8" isELIgnored="false" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%
    String path = request.getContextPath();
    String basePath = request.getScheme() + "://" + request.getServerName() + ":" + request.getServerPort()
            + path + "/";
    System.out.println("Login:" + basePath);
%>
<c:set var="basePath" value="<%=basePath%>" />
<!DOCTYPE html>
<html>
<head>
    <!-- Standard Meta -->
    <meta charset="utf-8" />
    <base href="${basePath }" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0">

    <!-- Site Properties -->
    <title>Missbe-Login</title>
    <link rel="stylesheet" type="text/css" href="static/dist/components/reset.css">
    <link rel="stylesheet" type="text/css" href="static/dist/components/site.css">

    <link rel="stylesheet" type="text/css" href="static/dist/components/container.css">
    <link rel="stylesheet" type="text/css" href="static/dist/components/grid.css">
    <link rel="stylesheet" type="text/css" href="static/dist/components/header.css">
    <link rel="stylesheet" type="text/css" href="static/dist/components/image.css">
    <link rel="stylesheet" type="text/css" href="static/dist/components/menu.css">

    <link rel="stylesheet" type="text/css" href="static/dist/components/divider.css">
    <link rel="stylesheet" type="text/css" href="static/dist/components/segment.css">
    <link rel="stylesheet" type="text/css" href="static/dist/components/form.css">
    <link rel="stylesheet" type="text/css" href="static/dist/components/input.css">
    <link rel="stylesheet" type="text/css" href="static/dist/components/button.css">
    <link rel="stylesheet" type="text/css" href="static/dist/components/list.css">
    <link rel="stylesheet" type="text/css" href="static/dist/components/message.css">
    <link rel="stylesheet" type="text/css" href="static/dist/components/icon.css">

    <script src="${basePath }static/assets/library/jquery.min.js"></script>
    <script src="${basePath }static/dist/components/form.js"></script>
    <script src="${basePath }static/dist/components/transition.js"></script>
    <link rel="shortcut icon" href="${basePath }static/img/favicon.ico">
    <style type="text/css">
        body {
            background-color: #DADADA;
        }
        body > .grid {
            height: 100%;
        }
        .image {
            margin-top: -100px;
        }
        .column {
            max-width: 450px;
        }
    </style>
    <script>
        $(document)
                .ready(function() {
                    $('.ui.form')
                            .form({
                                fields: {
                                    email: {
                                        identifier  : 'email',
                                        rules: [
                                            {
                                                type   : 'empty',
                                                prompt : 'Please enter your e-mail'
                                            },
                                            {
                                                type   : 'email',
                                                prompt : 'Please enter a valid e-mail'
                                            }
                                        ]
                                    },
                                    password: {
                                        identifier  : 'password',
                                        rules: [
                                            {
                                                type   : 'empty',
                                                prompt : 'Please enter your password'
                                            },
                                            {
                                                type   : 'length[6]',
                                                prompt : 'Your password must be at least 6 characters'
                                            }
                                        ]
                                    }
                                }
                            })
                    ;
                })
        ;
    </script>
</head>
<body>

<div class="ui middle aligned center aligned grid">
    <div class="column">
        <h2 class="ui teal image header">
            <img src="${basePath }static/img/favicon.ico" class="image">
            <div class="content">
                登录签到后台
            </div>
        </h2>
        <form class="ui large form" method="post" action="${basePath }login.action">
            <div class="ui stacked segment">
                <div class="field">
                    <div class="ui left icon input">
                        <i class="user icon"></i>
                        <input type="text"  id="login-name" name="username" placeholder="Username">
                    </div>
                </div>
                <div class="field">
                    <div class="ui left icon input">
                        <i class="lock icon"></i>
                        <input type="password" id="login-pass" name="userpass" placeholder="Password">
                    </div>
                </div>
                <div id="btn" class="ui fluid large teal submit button">Login</div>
            </div>

            <div class="ui error message"></div>

        </form>
    </div>
</div>
<script>
    $("#btn").click(function(){
        var name=$("#login-name").val();
        var pass=$("#login-pass").val();
        console.log(name+":"+pass);
        $(".form").submit();
    });
</script>
</body>

</html>
