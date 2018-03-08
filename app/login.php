<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==true){
		if($_SESSION['type']=='admin'){
		header("location: admin.php");
	}
	else{
	header("location: userfeed.php");
	}	
	}
	
?>


<?php
	$inv="";
	if($_SERVER['REQUEST_METHOD']=="POST"){
		$id=$_REQUEST['id'];
		$password=$_REQUEST['password'];
		$result=isvalididpass($id,$password);
		var_dump($result);
		if(mysqli_num_rows($result)==0)
		{  
					$inv="Invalid ID or Password";
 
			
		}
		else{
			$row=mysqli_fetch_assoc($result);
			
					if($row['type']=='admin')
					{
						$_SESSION['id']=$id;
					$_SESSION['name']=$row['name'];
					$_SESSION['type']=$row['type'];
					header('location: admin.php');
					}
					else{
					$_SESSION['id']=$id;
					$_SESSION['name']=$row['name'];
					$_SESSION['type']=$row['type'];
					header("location: userfeed.php");
					}
		}

	}
?>


<html>
<title>Login Form</title>
<head>
<style type="text/css">
.form {
  position: relative;
  z-index: 1;
  background: #FFFFFF;
  max-width: 300px;
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
  padding: 50px 30px;
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
  max-width: 300px;
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
    <h1>Welcome</h1>
  </div>
</div>
<div class="form">
  <div class="thumbnail"><img src="hat.svg"/></div>

	<table align='center' >
	
		<form method='post' class="login-form" >
			<tr>
				<td>ID</td>
				<td><input type='text' name='id'></td>
			</tr>
			
			<tr>
				<td>Password</td>
				<td><input type='password' name='password'></td>
			</tr>
			
			<tr>
				<td></td>
				
				<td align='right'><input type='submit' name='submit' value='Log-In'></br></td>
			</tr>
			<tr> <td></td>
			<td>
			
			<font color="red"><?=$inv?> </font>
			</td>
			</tr>
	
    
</form>
</div>
</table>
</body>
</html>