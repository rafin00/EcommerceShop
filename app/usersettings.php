<?php require_once "../service/person_service.php"; ?>

<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	
	if(isset($_REQUEST['success']))
	{
		$success=$_REQUEST['success'];
	}
	else 
		$success="";
	
		if($_SESSION['type']!='student')
		$cnr='teacherregistration.php';
	else
		$cnr='userregistration.php';
?>

<?php
$curpasser="";$newpasser="";$confpasser="";
$do=false;
	if($_SERVER['REQUEST_METHOD']=="POST"){
		if((!(empty($_REQUEST['current_password'])))&&(!(empty($_REQUEST['new_password'])))&&(!(empty($_REQUEST['conf_password']))))
		{
			$curpass=$_REQUEST['current_password'];
			$result=getpersoninfo($id);
			$row=mysqli_fetch_assoc($result);
			if($curpass==$row['password'])
			{
				
			if(($_REQUEST['new_password'])==($_REQUEST['conf_password']))
			{
				var_dump(setnewpassword($id,$_REQUEST['conf_password']));
				
				header('location: usersettings.php?success="Password Successfully Changed"');
			}
			}
			else
			{
				$curpasser='*Wrong Password';
			}
     	}
	
	}
?>


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
</td><td >	
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

<form method=post>

<table border=0 width=60% >
<tr align=ceter><td colspan=3><?=$success?></td></tr>
<tr>
<td align=left>Enter Current Password : </td> <td align=right><input name='current_password' type=password></td><td><font color='red'><?=$curpasser?></font></td>
</tr>
<tr>
<td align=left>Enter New Password : </td> <td align=right><input name='new_password' type=password onkeyup='matchpassword()'></td><td><font color='red'><?=$newpasser?></font></td>
</tr>
<tr>
<td align=left>Enter Confirm new Password : </td> <td align=right><input name='conf_password' type=password onkeyup='matchpassword()'></td><td><font color='red'><div id='matcherror'></div></font></td>
</tr>
<tr>
<td align=right colspan=2><input name='save' value='Save' type=submit><td>
</tr>
<table>
</form>

</td>


</tr></table>
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

function matchpassword()
{   console.log('tree');
	var newtext=document.getElementsByName("new_password")[0];
	var conftext=document.getElementsByName("conf_password")[0];
	var divtext=document.getElementById('matcherror');
	if(newtext.value==conftext.value)
	{
		divtext.innerHTML="matched";
		document.getElementsByName("save")[0].disabled = false;
		}
	else
	{
		divtext.innerHTML="*passwords doesn't match";
		
document.getElementsByName("save")[0].disabled = true;
	}
}
	
</script>
