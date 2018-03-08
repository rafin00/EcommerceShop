<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	
	
		$myname=$_SESSION['name'];
			
			if($_SESSION['type']!='student')
		$cnr='teacherregistration.php';
	else
		$cnr='userregistration.php';
		
		
	
?>








<!DOCTYPE html>
<html>

<head>
<link rel="stylesheet" type="text/css" href="styler.css">

</head>
<body style="background-color:rgb(220,220,255);">

	<table border=0 cellpadding="0" width=100% cellspacing="0" >
		<tr style="height:10vh; color:white; background-color:rgb(103, 103, 255);">
	<td align=center  ><h1><strong>EDWeb</strong></h1></td>
	<td align='left' >
	<div class="dropdown">
 Search : <input class="dropbtn" id='textbox' onkeyup="sugfunction()" >
  <div class="dropdown-content" id='output' >
    <!--<a href="userprofile.php">mansib</a> -->
  </div>
</div>
</td>
<td >	
	<div style="float: right;" > 
	 <div class="settingsdown">
  <button class="settingsbtn">Settings</button>
  <div class="settingsdown-content">
    <a href='usersettings.php'>Change Password</a>
    </div>
</div> 
<a id='logout' href='logout.php' style="color:white;">Logout</a>
<a href='inbox.php'><img border="0" alt="W3Schools" src="inbox.png" width="45" height="30"></a>
	</div> 
	</td> 
	
</tr>

		<tr >
		
		<td width='25%'  style="height:70vh; background-color: rgb(150,150,255)" >
<div id='navtable'>


 </br>
<a id='nav' href="userfeed.php"> Home </a> </br>
</br><a id='nav' href="userprofile.php?var_id=<?=$id?>"> Profile </a></br>
</br><a id='nav' href="<?=$cnr?>">Courses & Results</a> </br>
</br><a id='nav' href='gotoregis.php'>Go To Registration</a> </br>
</br><a id='nav' href="offeredcourses.php">Offered Courses</a> </br>
</br><a id='nav' href='logout.php?oid=""'>Logout</a> > 


</div>
</td>
</td >
		<td width='75%' colspan=2 style="height: 70vh;" valign="top">
		
		<table width=100% border=1>
		<tr>
		<th>Course ID</th>
		<th>Title</th>
		<th>Capacity</th>
		<th>Count</th>
		</tr>
		
		<?php $result=getofferedcourses(); 
		while($row=mysqli_fetch_assoc($result))
		{
		
		echo "<tr align='center'>";
		echo '<td>'.$row['course_id'].'</td>';
		echo '<td>'.$row['course_name'].'['.$row['section'].']</td>';
		echo '<td>'.$row['capacity'].'</td>';
		echo '<td>'.$row['count'].'</td>';
		
		echo "</tr>";
		}
		?>
		
		</table>
		
		
		</td>
				</tr>
				
	</table>

</body>
</html>

<script>
function sugfunction(){
          var idtextbox=document.getElementById('textbox');
	var divobj=document.getElementById('output');
	
	if(idtextbox.value=="")
	{
		divobj.innerHTML="";
	}
	else
	{
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
		      
			divobj.innerHTML=this.responseText;
			}
		 }
	xmlhttp.open("POST","suggestionhandler.php?searchvalue="+idtextbox.value,true);
	xmlhttp.send();
}
}	  


</script>

