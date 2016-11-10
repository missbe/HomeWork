<%--
  Created by IntelliJ IDEA.
  User: Administrator
  Date: 2016/10/29 0029
  Time: 下午 12:17
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%
    String path = request.getContextPath();
    String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>
<c:set var="basePath" value="<%=basePath %>" />
<html>
<head>
    <title>ADD</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="http://cdn.static.runoob.com/libs/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="http://cdn.static.runoob.com/libs/jquery/2.1.1/jquery.min.js"></script>
    <script src="http://cdn.static.runoob.com/libs/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
<h3 class="text-info text-center">
    <c:if test="${!empty requestScope.message}">
        ${requestScope.message}
    </c:if>
</h3>
<form class="form-horizontal" role="form" action="${basePath}user/add" method="post">
    <div class="form-group">
        <label for="firstname" class="col-sm-2 control-label">网名</label>
        <div class="col-sm-4">
            <input type="text" class="form-control input-lg" id="firstname" name="username"
                   placeholder="请输入网名" tabindex="0">
        </div>
    </div>
    <div class="form-group">
        <label for="lastname" class="col-sm-2 control-label">真实名字</label>
        <div class="col-sm-4">
            <input type="text" class="form-control input-lg" id="lastname" name="truename"
                   placeholder="请输入真实名字" tabindex="1">
        </div>
    </div>
    <div class="form-group">
        <label for="password" class="col-sm-2 control-label">你的密码</label>
        <div class="col-sm-4">
            <input type="text" class="form-control input-lg" id="password" name="password"
                   placeholder="请输入密码" tabindex="2">
        </div>
    </div>
    <div class="form-group">
        <div class="col-sm-offset-2 col-sm-10">
            <button  class="btn btn-default" onclick="return check()">确认添加</button>
        </div>
    </div>
</form>
<script>
    function check(event) {
        if($("#firstname").val()==''|| $("#lastname").val()=='' || $("#password").val()==''){
            alert("请填写完整");
           return false;
        }else{
//            $(".form-horizontal").submit();
        }
    }
</script>
</body>
</html>
