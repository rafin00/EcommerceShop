<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	
	$pid=$_REQUEST['pid'];
	
	$text=$_REQUEST['text'];

			$result= getpersoninfo($id);
			if($result==true)
			{	$row=mysqli_fetch_assoc($result);
		$myname=$row['name'];
			}

		
			
			addnewcomment($pid,$id,$text);

			$result = getlastcommenttime();
			$row=mysqli_fetch_assoc($result);
			

		echo '<p id="comments"><a  href="userprofile.php?var_id='.$id.'">'.$myname.'</a> '.$text.'</br><small>('.$row['time'].')</p></small>';
		
	
?>

