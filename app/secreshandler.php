<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	
	$sem=$_REQUEST['sem'];
	
	
			
			$result=getreginfo($id,$sem);
			
		echo "<table>";	
			?>
			<tr>
			<th>Course ID
			</th>
			<th>Course Name
			</th>
			<th>Section
			</th>
			<th>Grade
			</th>
			</tr>
		<?php	
		while($row=mysqli_fetch_assoc($result))
			{ 
		?>
		
		
		<tr align=center>
			
			<td> <?=$row['course_id']?> </td>
			<td> <?=$row['course_name']?> </td>
			<td> <?=$row['section']?> </td>
			<td> <?=$row['grade']?> </td>
		</tr>
		
		<?php

		}
		echo "</table>";
		?>
	

