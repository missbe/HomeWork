<%--
  Created by IntelliJ IDEA.
  User: Administrator
  Date: 2016/11/1 0001
  Time: 下午 7:36
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
    <title>UserList</title>
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
<div class="container">
    <div class="row clearfix">
        <div class="col-md-12 column">
            <table class="table table-striped table-bordered table-hover ">
                <thead>
                <tr>
                    <th>
                        编号
                    </th>
                    <th>
                        用户名
                    </th>
                    <th>
                        真实名
                    </th>
                    <th>
                        密码
                    </th>
                    <th>
                        编辑
                    </th>
                </tr>
                </thead>
                <tbody>
                <c:if test="${!empty requestScope.userList}">
                <c:forEach begin="1" items="${requestScope.userList}" var="user">
                <tr class="info">
                    <td>
                        ${user.id}
                    </td>
                    <td>
                            ${user.username}
                    </td>
                    <td>
                            ${user.truename}
                    </td>
                    <td>
                            ${user.password}
                    </td>
                    <td>
                        <a style="color:rebeccapurple">编辑</a>
                    </td>
                </tr>
                </c:forEach>
                </c:if>
                </tbody>
            </table>
        </div>
    </div>
</div>
</body>
</html>
