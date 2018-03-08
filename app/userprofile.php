<?php require_once "../service/person_service.php"; ?>


<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	$oid=$_REQUEST['var_id'];
	
	if($_SESSION['type']!='student')
		$cnr='teacherregistration.php';
	else
		$cnr='userregistration.php';
		
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

<?php
	{
			$result = getpersoninfo($oid);
			$row=mysqli_fetch_assoc($result);
			
?>


	<table align='center' border=0 width=100%>
		<tr align='right' >
			<td colspan='2'> 
			<button onclick="msgpopuptoggle()"> Send Message</button> 
			</td>
			  
			
		</tr>
		<tr align=center>
			
			<td colspan=2> <img src="profileimg/<?=$row['photo']?>" width=300 alt=""> </td>
			
		</tr>
		
		<tr align=center>
			
			<td colspan=2><strong> <?=$row['name']?> </strong></td>
			
		</tr>
		
		
		<tr>
			
			<td> ID : </td>
			<td align='right'> <?=$row['user_id']?></td>
		</tr>
		
		<tr>
			
			<td> Email : </td>
			<td align='right'> <?=$row['email']?></td>
		</tr>
		
		<tr>
			
			<td> Type : </td>
			<td align='right'> <?=$row['type']?></td>
		</tr>
		
		<tr>
			
			<td> Status : </td>
			<td align='right'> <?=$row['status']?></td>
		</tr>
		
		<tr>
			
			<td> Admission Date : </td>
			<td align='right'> <?=$row['started']?></td>
		</tr>
		
		<tr>
			
			<td> Graduation : </td>
			<td align='right'> <?=$row['finished']?></td>
		
		
		</tr>
		
	</table>


<?php

		
			
	}
?>

</td>



</tr></table>

<div id="msgpopupposition">
			<div id='msgpopupwrapper'>
			<div id='msgpopupcontent'>
			To : <?=$row['name']?></br>
			Type Message:
			<input name='msgpopupbox'>
			<button onclick="msgpopupsend('<?=$oid?>')">Send</button>
			<button align=right onclick="msgpopuptoggle()" >close</button>
			</div>
			</div>
			</div>

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

function msgpopuptoggle()
{
	var e=document.getElementById('msgpopupposition');
	if(e.style.display=='block')
	{
		e.style.display='none';
	}
	else
	e.style.display='block';
}
	
function msgpopupsend(otherid)
{
	var text=document.getElementsByName('msgpopupbox')[0];
	if(text.value=="")
	{
		
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
		      console.log("dasd");
			msgpopuptoggle();
			}
		 }
	xmlhttp.open("POST","msgpopuphandler.php?oid="+otherid+"&text="+text.value,true);
	xmlhttp.send();
}
}	
	
</script>



