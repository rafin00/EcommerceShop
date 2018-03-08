<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	
?>
<html>
<head>
<title>Admin Panel</title>
<style type="text/css">
.form {
  position: relative;
  z-index: 1;
  background: #FFFFFF;
  max-width: 49%;
  margin: 0 auto 100px;
  padding: 30px;
  border-top-left-radius: 3px;
  border-top-right-radius: 3px;
  border-bottom-left-radius: 3px;
  border-bottom-right-radius: 3px;
  text-align: center;
}
.form .thumbnail {
  background: #EF3B3A;
  width: 150px;
  height: 150px;
  margin: 0 auto 30px;
  padding: 30px 30px;
  border-top-left-radius: 100%;
  border-top-right-radius: 100%;
  border-bottom-left-radius: 100%;
  border-bottom-right-radius: 100%;
  box-sizing: border-box;
}
.form .thumbnail img {
  display: block;
  width: 100%;
}
.form input {
  outline: 0;
  background: #f2f2f2;
  width: 100%;
  border: 0;
  margin: 0 0 15px;
  padding: 15px;
  border-top-left-radius: 3px;
  border-top-right-radius: 3px;
  border-bottom-left-radius: 3px;
  border-bottom-right-radius: 3px;
  box-sizing: border-box;
  font-size: 14px;
}
.form .button {
  outline: 0;
  background: #EF3B3A;
  width: 100%;
  border: 0;
  padding: 15px;
  border-top-left-radius: 3px;
  border-top-right-radius: 3px;
  border-bottom-left-radius: 3px;
  border-bottom-right-radius: 3px;
  color: #FFFFFF;
  font-size: 14px;
  -webkit-transition: all 0.3 ease;
  transition: all 0.3 ease;
  cursor: pointer;
}
.container {
  position: relative;
  z-index: 1;
  max-width: 31%;
  margin: 0 auto;
}
.container:before, .container:after {
  content: "";
  display: block;
  clear: both;
}
.container .info {
  margin: 50px auto;
  text-align: center;
}
.container .info h1 {
  margin: 0 0 15px;
  padding: 0;
  font-size: 36px;
  font-weight: 300;
  color: #1a1a1a;
}
.container .info span {
  color: #4d4d4d;
  font-size: 12px;
}
.container .info span a {
  color: #000000;
  text-decoration: none;
}
.container .info span .fa {
  color: #EF3B3A;
}
.logoutBTN {
	width: 12%;
    padding: 3px;
}
body {
  background: #ccc;
  font-family: "Roboto", sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}
body:before {
  content: "";
  position: fixed;
  top: 0;
  left: 0;
  display: block;
  background: rgba(255, 255, 255, 0.8);
  width: 100%;
  height: 100%;
}
  </style>
</head>
<body>
<div class="container">
  <div class="info">
    <a href="admin.php"><h1>Welcome To Admin Panel</h1></a>
  </div>
</div>
<div class="form">
  <div class="thumbnail"><img src="administrator.png"/></div><a href="logout.php" style="width=10%"><input style="
    position: relative;
    position: absolute;
    top: 30px;
    right: 20px;
    width: 115px;
	padding: 4px 0px 5px 0px;
" class="button " type="button" value="Logout" /></a>
  <form class="login-form" style="text-align: -webkit-center">
	<table>
		
		<tr>
			<td>
				<a href="showInfo.php"><input  class="button" type="button" name='submit' value="Show Student Record"/></a>
			</td>
			<td>
				<a href="addStudentRec.php"><input  class="button" type="button" name='submit' value="Add User"/></a>
			</td>
		</tr>
		<tr>
			<td>
				<a href="showInfo.php"><input  class="button" type="button" name='submit' value="Update Student Record"/></a>
			</td>
			<td>
				<a href="registrationcontrol.php"><input  class="button" type="button" name='submit' value="Registration Control"/></a>
			</td>
		</tr>
		<tr>
			<td >
				<a href="addCourses&Section.php"><input  class="button" type="button" name='submit' value="Course & Section Control"/></a>
			</td>
			<td >
				<a href="semestercontrol.php"><input  class="button" type="button" name='submit' value="Semester Control"/></a>
			</td>
		</tr>
	
	</table>
    
    
  </form>
</div>

</body>

</html>