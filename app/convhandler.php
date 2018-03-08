<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	
	$text=$_REQUEST['searchvalue'];
	
	
		
			if($text=="")
			{
				
			
			$result =getconvpeople($id);
			if($result==true)
			{	while($row=mysqli_fetch_assoc($result))
				{
	
						$otherid=$row['sender_id'];
						
					
					$nameresult=getpersoninfo($otherid);
					$othername=mysqli_fetch_assoc($nameresult);
					
					echo '<a id="chatpeople" href="inbox.php?oid='; 
					echo $otherid; 
					echo '">';
					echo $othername['name'];
					echo '</a>';
					echo "</br>";
				}
			}
		}
		else
		{
			
			$result = searchconv($id,$text);
			if($result==true)
			{	while($row=mysqli_fetch_assoc($result))
				{
	
						$otherid=$row['user_id'];
						
					
					$othername=$row['name'];
					
					echo '<a id="chatpeople" href="inbox.php?oid='; 
					echo $otherid; 
					echo '">';
					echo $othername;
					echo '</a>';
					echo "</br>";
				}
			}
		}
		
	
	
		
	
?>


