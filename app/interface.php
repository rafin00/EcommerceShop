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
?>




<html>
<head>
<link rel="stylesheet" type="text/css" href="styler.css">
</head>
<body>
<table border=1 width=100% cellpadding="0" cellspacing="0">

<tr style="height:10vh">
	<td >EDWeb</td>
	<td align='left' >
	<div class="dropdown">
 Search :  <input class="dropbtn" id='textbox' onkeyup="sugfunction()" >
  <div class="dropdown-content" id='output' >
    
  </div>
</div>
</td><td>	
	<div style="float: right;"> 
	<a href='inbox.php?oid=""'>Inbox</a> <div class="settingsdown">
  <button class="settingsbtn">Settings</button>
  <div class="settingsdown-content">
    <a href='usersettings.php'>Change Password</a>
    </div>
</div> <a href='logout.php'>logout</a>
	</div> 
	</td> 
	
</tr>

<tr>
<td width=25% valign="top" style="height:82vh;">
<div >

 <a href="userfeed.php"> Home </a> </br>
<a href="userprofile.php?var_id=<?=$id?>"> Profile </a></br>
<a href="userregistration.php"> Courses & Results</a> </br>
<a href='logout.php?oid=""'>logout</a> 

</div>
</td>
<td width=75% colspan=2>

<!--code here -->
</td>



</tr></table>
</body>
</html>
<script>
function sugfunction(){
          var idtextbox=document.getElementById('textbox');
	var divobj=document.getElementById('output');
	//document.write(prev.value);
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
