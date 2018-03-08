<?php require_once "../service/person_service.php"; ?>
<?php
	$id=$_REQUEST['id'];
	
		
		deleteuser($id);
		header("location: showInfo2.php");
	
?>