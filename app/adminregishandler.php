<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_REQUEST['id'];
	
	$course=$_REQUEST['course'];
	
	$value=$_REQUEST['value'];
	$name=explode('_',$course);
	//echo $value.'g';
			if($value==1)
			$result= addtoregis($id,$name[0],$name[1],$name[2]);
		else
			$result=removefromregis($id,$name[0],$name[1],$name[2]);
	//var_dump($result);
		
?>

