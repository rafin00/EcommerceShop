<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	
	$selval=$_REQUEST['selval'];
	$sem=$_REQUEST['sem'];
	$course=explode('_',$selval);
	
			$result= getstudents($course[0],$course[1],$sem);
			if($result==true)
			{// var_dump($result); 
echo '<table>';
echo '<tr>';
echo '<th>Student ID</th>';
echo '<th> Name </th>';
echo '<th>Marks</th><th></th>';
echo '</tr>';		
		while($row=mysqli_fetch_assoc($result))
				{//echo  $course[0];
					$textbox=$row['course_id'].'_'.$row['section'];
					$textbox1=$row['course_id'].'_'.$row['section'].'_'.$row['user_id'];
					echo '<tr>';
					echo '<td><p >'.$row['user_id'].'</p></td>';
					echo '<td><p >'.$row['name'].'</p></td>';
					echo '<td><input size="3"  name='.$textbox1.' value="'.$row['grade'].'" maxlength="2" ></td>';
					//echo '<td><button  onclick="save('.$textbox.','.$row['user_id'].')">Save</button></td>';
					echo '<td><button  onclick="myfunc('.$row['user_id'].','.$sem.')">Save</button></td>';
					echo '</tr>';
				}
			echo '</table>';
			}

			

		
	
?>

