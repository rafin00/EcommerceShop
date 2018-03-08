<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	$uid=$_REQUEST['uid'];
	$sem=$_REQUEST['sem'];
	echo $uid;
	echo $sem;
	unconfirmreg($uid,$sem);
	//var_dump($result);
		
?>

