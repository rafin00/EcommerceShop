<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	
	$sem=$_REQUEST['selval'];
	//
	
	 $result=getcourses($id,$sem);
		    
				if($result==true)
				{
					?>
				<select name="course" width=100% onchange="changefunc(this)">
						<?php
						
						
						while($row=mysqli_fetch_assoc($result))
						{
							$val=$row['course_id'].'_'.$row['section'];
							$showval=$row['course_name'].'.['.$row['section'].']';
						?>
						
						<option value="<?=$val?>"><?=$showval?></option>
						<?php } ?>
						
					</select>
				
				
			<?php	} ?>