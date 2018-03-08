<?php require_once "../service/person_service.php"; ?>
<?php require_once "../service/validation_service.php"; ?>

<?php
	$inv=""; $isvalid=true;
	if($_SERVER['REQUEST_METHOD']=="POST"){
		
		 $id=trim($_REQUEST['id']);
		 $name=trim($_REQUEST['name']);
		 $type=trim($_REQUEST['type']);
		 $email=trim($_REQUEST['email']);
		 $status=trim($_REQUEST['status']);
		 $password=trim($_REQUEST['password']);
		
		if(!(($_FILES['photo']['name'])==""))	
		{
			$img=$_FILES['photo'];
			$img_name=$img['name'];
			$img_tmp=$img['tmp_name'];
			$img_ext=explode('.',$img_name);
			$img_ext= strtolower(end($img_ext));
			
			$imgname=uniqid().'.'.$img_ext;
			
			$img_dest= 'profileimg/'.$imgname;
			move_uploaded_file($img_tmp,$img_dest);
			$do=true;
		}
else
{
	$isvalid=false;
}	
			if(empty($id))
			{
				$isvalid=false;
				$inv="fill all feilds";
			}
			
			 if(empty($name))
			 {$isvalid=false;
		 $inv="fill all feilds";
			}
			else
			{
				$isvalid=isValidPersonName($name);
			}
			
			if(empty($type))
			{$isvalid=false;
			$inv="fill all feilds";
			}
			
			if(empty($email))
			{$isvalid=false;
			$inv="fill all feilds";
			}
			
			if(empty($status))
			{$isvalid=false;
		$inv="fill all feilds";
			}
			
			if(empty($password))
			{$isvalid=false;
		$inv="fill all feilds";
			}
			
			
			
			
			//$query="INSERT INTO `user_info` (`name`, `type`, `email`, `status`,`password`)VALUES( '$name', '$type', '$email', '$status', '$password')";
			
			//$result = mysqli_query($conn,$query);
			if($isvalid==true){
			$result=addnewuser($id,$name,$type,$email,$status,$password,$imgname);
			//var_dump($result);
			if($result==true){
				$inv="Record Added "."<a href='showInfo.php'>show</a>";
				
			}
			}
		
	}

?>
<html>
<head>
<title>Login Form</title>
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
  text-align: center;
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
  <a href="admin.php"><h1>Welcome To Admin Panel</h1></a>
  <a href="logout.php" style="width=10%"><input style="
   
    top: 30px;
    right: 20px;
    width: 115px;
	padding: 4px 0px 5px 0px;
" class="button " type="button" value="Logout" /></a>
    <h1>User Registration</h1>
  </div>
</div>
<div class="form">
  <div class="thumbnail"><img src="hat.png"/></div>
<form method="post" enctype="multipart/form-data">
	ID  <input type="text" name="id"/></br></br>
	NAME:    <input type="text" name="name"/></br></br>
	TYPE:    <input type="text" name="type"/></br></br>
	EMAIL:   <input type="text" name="email"/></br></br>
	STATUS:  <input type="text" name="status"/></br></br>
	PASSWORD: <input type="text" name="password"/></br></br>
	PROFILE IMAGE :  <input type='file' name="photo" accept="image/*" ></br></br>
	<input class="button"type="submit" value="Register" />
	<font color="red"> <?=$inv?>
</form>
</div>




</body>
</html>