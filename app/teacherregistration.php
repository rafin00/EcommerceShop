<?php require_once "../service/person_service.php"; ?>

<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	$textr="";
	if(isset($_REQUEST['oid']))
	{
		$oid=$_REQUEST['oid'];
	}
	else 
		$oid="";
	if($_SESSION['type']!='student')
		$cnr='teacherregistration.php';
	else
		$cnr='userregistration.php';
?>

<?php
	if($_SERVER['REQUEST_METHOD']=="POST"){
		if((!(empty($_REQUEST['msgbox'])))&&($oid!=""))
		{
			$conn = mysqli_connect("localhost","root", "", "wt_project");
			if($conn)
			{
				$textval=$_REQUEST['msgbox'];
				addnewmsg($textval,$id,$oid);
				header("location: inbox.php?oid=$oid");
			}
		}
	
	}
?>


<html>
<head>
<link rel="stylesheet" type="text/css" href="styler.css">
</head>
<body style="background-color:rgb(220,220,255);" >
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
</br><a id='nav' href='logout.php?oid=""'>Logout</a> 


</div>
</td>
<td width=75% colspan=2 style="vertical-align: text-top;overflow-y: auto;">


	<select name="semesters" width=100% onchange="changesemesters(this)">
						<?php
						$result=getsemesters($id);
						
						while($row=mysqli_fetch_assoc($result))
						{
							$val=$row['reg_id'];
							$showval=$row['sem_name'];
						?>
						
						<option value="<?=$val?>"><?=$showval?></option>
						<?php } ?>
						
					</select>
	<div id='courses'></div>
	<div id='people'></div>
			


</td>



</tr></table>
</body>
</html>
<script>

window.onload = function()
{ console.log('here');
  a = document.getElementsByName("semesters")[0];
  a.selectedIndex = a.options.length-1;
    changesemesters(a);
};
  
  

function myfunc(test,sem)
{	
//
var selectBox = document.getElementsByName("course")[0];
    var selectedValue = selectBox.options[selectBox.selectedIndex].value;
	//console.log(test);
	//console.log(selectedValue);
	var a = selectedValue+'_'+test;
	var grade = document.getElementsByName(a)[0];
	console.log(a);
	console.log(grade.value);
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
		    //  console.log('here');
			console.log(this.responseText);
			}
		 }
	xmlhttp.open("POST",encodeURI("gradeshandler.php?info="+a+'&grade='+grade.value+'&semester='+sem),true);
	xmlhttp.send();
}

function changesemesters(select)
{
	// var selectBox = document.getElementsByName("course")[0];
    var selectedValue = select.options[select.selectedIndex].value;
    console.log(selectedValue);
	var divtext=document.getElementById("courses");
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
			a = document.getElementsByName("course")[0];
  a.selectedIndex = 0;
 changefunc(a);
			}
		 }
	xmlhttp.open("POST","semestershandler.php?selval="+selectedValue,true);
	xmlhttp.send();
	
	 
}

function changefunc(select)
{
	  a = document.getElementsByName("semesters")[0];
  
    
    var selectedValue = select.options[select.selectedIndex].value;
    console.log(selectedValue);
    console.log(a.options[a.selectedIndex].value);
    
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
	xmlhttp.open("POST","sectionstudentshandler.php?selval="+selectedValue+"&sem="+a.options[a.selectedIndex].value,true);
	xmlhttp.send();
	
}	
</script>
