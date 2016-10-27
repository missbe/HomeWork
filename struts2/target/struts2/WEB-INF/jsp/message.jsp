<%--
  Created by IntelliJ IDEA.
  User: Administrator
  Date: 2016/10/27 0027
  Time: 下午 9:47
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java"  %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%
    String path = request.getContextPath();
    String basePath = request.getScheme() + "://" + request.getServerName() + ":" + request.getServerPort()
            + path + "/";
    System.out.println("Login:" + basePath);
%>
<c:set var="basePath" value="<%=basePath%>" />
<html>
<head>
    <title>Message</title>
    <link   rel="stylesheet"  href="http://cdn.static.runoob.com/libs/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="http://cdn.static.runoob.com/libs/jquery/2.1.1/jquery.min.js"></script>
    <script src="http://cdn.static.runoob.com/libs/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
<div class="container">
    <div class="row clearfix" style="margin-top:10%;">
        <div class="col-md-3 col-md-offset-2 ">
            <img alt="200*200" src="${basePath }/static/img/message.jpg" />
        </div>
        <div class="col-md-6 " style="margin-top:7%;">
            <dl>
                <dt>
				<span style="font-size:32px">
				<p class="text-info" ><b>提示信息</b></p>
				</span>
                </dt>
                <dd>
					<span style="font-size:20px">
					<p class="text-warning" ><b>Message:<%=request.getAttribute("message")%></b></p>
					</span>
                </dd>
            </dl>
        </div>
    </div>
</div>
</body>
</html>
