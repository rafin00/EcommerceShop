<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	
	
	$svalue=$_REQUEST['searchvalue'];
	
			$result = getsuggestions($id,$svalue);
			
			if($result==true)
			{
		
				while($row=mysqli_fetch_assoc($result))
				{
					echo '<a href="userprofile.php?var_id='.$row['user_id'].'">'.$row['name'].'</a>';
					
				}
				
			}
			
		
	
	
		
	
?>


