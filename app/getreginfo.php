<?php require_once "../service/person_service.php"; ?>
<?php


	$sem=$_REQUEST['sem'];
	$id=$_REQUEST['uid'];
	echo $sem;
	echo $id;
	
	$getoc=isopen($sem);
	$row=mysqli_fetch_assoc($getoc);
	if($row['status']=='open') {
?>
<a href="admin.php"><h1>Welcome To Admin Panel</h1></a>
<table>
<?php

	
	$result=isconfirmed($sem,$id);
	if($row=mysqli_fetch_assoc($result))
	{
	
		echo "<tr><td>";
		echo "<div id='rstatus'>confirmation status : ".$row['status'].'</div>';
		echo "</td></tr>";
			if($row['status']=='confirmed')
			{
				$dis='disabled'; $sdis='';
			}
			else 
			{$dis=''; $sdis='disabled'; }
	}
	
$regisresult=getremainingcoursesad($id);
		while($row=mysqli_fetch_assoc($regisresult))
		{  $chk='checked';
			$boxname=$row['course_id'].'_'.$row['course_name'].'_'.$row['section'];
			$res=istaken($id,$row['course_id'],$row['section']);
			if(mysqli_num_rows($res)==0)
			{
				$chk='';
			}
			else
			{$chk='checked';  }
		
		?>
		<tr>
		<td>
		
		<input type="checkbox" name='<?=$boxname ?>' <?=$dis?> value=1 <?=$chk?> onclick="check('<?=$boxname?>','<?=$id?>')" >
		
		</td>
		
		<td>
		<?=$row['course_id']?>
		</td>
		
		<td>
		<?=$row['course_name']?>[<?=$row['section']?>]
		</td>
		</tr>
		<?php } 
		
		
		?>
		<tr><td>
		
		<input type = 'button' name='savebutton' onclick="confirm()" value='Save' <?=$dis?>>
		<input type = 'button' name='unsavebutton' onclick="disconfirm()" value='Unsave' <?=$sdis?>>
		</td></tr>
		</table>
		<?php } 
		else
		{
			$result=getregisterdcourses($sem,$id);
			while($row=mysqli_fetch_assoc($result))
			{
			echo '<p>'.$row['course_id'].' '.$row['course_name'].' '.$row['section'].'</p>';
		?>
		
		<?php } 
		}
		
		?>
<script>

</script>