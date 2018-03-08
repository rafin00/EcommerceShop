<?php require_once "../service/person_service.php"; ?>
<form method="post">
	
	STATUS<br/><input name="status"/><br/> 
	EMAIL<br/><input name="email"/><br/>
	PASSWORD<br/><input type="password" name="password"/><br/>
	
	
	<input type="submit" />
</form>


<?php
	if($_SERVER['REQUEST_METHOD']=="POST"){	
		$id=$_REQUEST['id'];
		$password=$_REQUEST['password'];
		$status=$_REQUEST['status'];
		$email=$_REQUEST['email'];
		$conn = mysqli_connect("localhost","root", "", "wt_project");
		if($conn){
			
			//$query="UPDATE `user_info` SET `email` = '$email', `status` = '$status', `password` = '$password' WHERE `user_info`.`user_id` = '$id'";
			//mysqli_query($conn,$query);
			updateuser($email,$status,$password,$id);
			echo "successfully updated"." <a href='showInfo.php'>show</a>";
			//header("location: showInfo.php");
		}
	}
?>
