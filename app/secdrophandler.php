<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	$sem=$_REQUEST['sem'];
	
			//$result= assigngrade($infos[0],$infos[1],$infos[2],$grade,$sem);
	//echo $id.$sem;
	?>
	<select name="course"  >
	<?php
						$result=getpostto($id,$sem);
						
						while($row=mysqli_fetch_assoc($result))
						{
							$val=$row['course_name'].'.['.$row['section'].']';
						
						?>
						
						<option value="<?=$val?>"><?=$val?></option>
						<?php } ?>
						
					</select>
	


