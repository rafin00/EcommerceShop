<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
		$id=$_SESSION['id'];
		
?>



<html>
<body>

	<table align='center' >
		<tr align='right' >
			<td colspan='4'> <a href="userfeed.php"> HOME <a href="logout.php">logout</a> <a href="userregistration.php">Registration</a> </td>
			
		</tr>
		
		<tr>
			
			<td> Course ID </td>
			<td > Course Name</td>
			<td > Section </td>
			<td > Grade </td>
		</tr>
		<?php 
			//$query="SELECT * FROM registration where user_id=$id";
			//$result = mysqli_query($conn,$query);
			$result = getreginfo($id);
		while($row=mysqli_fetch_assoc($result))
			{ 
		?>
		
		
		<tr>
			
			<td> <select name="course" width=100% onchange='changefunc()'>
						<?php
						$result=getsections($id);
						
						while($row=mysqli_fetch_assoc($result))
						{
							$val=$row['course_name'].'.['.$row['section'].']';
						
						?>
						
						<option value="<?=$val?>"><?=$val?></option>
						<?php } ?>
						
					</select> <form method='post'> <input type='submit'> </form> </td>
			
		</tr>
		
		<?php

		}
		
		?>
		<tr>
		<td>
		<div id = 'people'>
		</div>
		</td>
		</tr>
		</table>

</body>
</html>


<script>
function changefunc()
{
	 var selectBox = document.getElementsByName("course")[0];
    var selectedValue = selectBox.options[selectBox.selectedIndex].value;
    console.log(selectedValue);
	var divtext=document.getElementById("people");
	 if (window.XMLHttpRequest) 
		 {
			xmlhttp=new XMLHttpRequest();
		 } 
		 else 
		 { 
			xmlhttp=new ActiveXObject("Microsoft.XMLHTTP");
		 }
		 xmlhttp.onreadystatechange=function() 
		 {
			if (this.readyState==4 && this.status==200) 
			{
		      
			divtext.innerHTML=this.responseText;
			}
		 }
	xmlhttp.open("POST","sectionstudentshandler.php?selval="+selectedValue,true);
	xmlhttp.send();
	
}
</script>