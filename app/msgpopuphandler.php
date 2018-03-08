<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
;
	$oid=$_REQUEST['oid'];
	$text=$_REQUEST['text'];

			$result=addnewmsg($text,$id,$oid);
			if($result==true)
			{
		
				
				
			}
		
	
?>


