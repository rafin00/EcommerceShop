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
<body style="background-color:rgb(220,220,255);">
<table border=0 cellpadding="0" width=100% height=100% cellspacing="0" >
		<tr style="height:10%; color:white; background-color:rgb(103, 103, 255);">
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
		
		<td width='25%'  style="height:90%; background-color: rgb(150,150,255)" >
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
<td width=50% >
<table border=0 width=100% style="height:10%;">
<tr><td align='center'>
<p  align='center'> 
<?php



if($oid=="")
{
	echo "Select a conversation first</br>";
	echo "</br>";
	}
else {

			$result2 = getpersoninfo($oid);
			$row2=mysqli_fetch_assoc($result2);
			echo $row2['name'];
			echo "</br>";
			echo '<a href="userprofile.php?var_id='.$oid.'">View Profile</a>';
				
}
?>
</br>
 </p> 
</td></tr>
</table>

<table border="0" style="height:60%;" width=100%>
    <tr>
        <td valign="bottom" style="background-color:rgb(230,230,255)">
            <div id="msgBox">
            
<?php if($oid==""){ echo '<p align="center">Please select a classmate to chat with</p>';}

	else
	{
		
	
		
			$result = getconversation($id,$oid);
			if($result==true)
			{	while($row=mysqli_fetch_assoc($result))
				{
					if($row['sender_id']==$id)
					{
						
				   	echo '<p align="right" title="'.$row['time'].'">'.$row['text'].'</p>';
					}
					else
					{
						echo '<p align="left" title="'.$row['time'].'">'.$row['text'].'</p>';
					}
				}
			}
		
	}
?>

			
			 </div>
        </td>
    </tr>    
</table>

<table border=0 style="height:20%;">
<tr><td>

<form method='post' enctype="multipart/form-data">
Type Message : <input size=60% name='msgbox'>&nbsp;
 <input type='submit' value='Send'>

</form>
</td></tr>

</form>
</table>
</td>

<td width=25% valign='top'>



  <div class="dropdown" style="width: 100%;">
 Search :  <input class="dropbtn" id='convtextbox' onkeyup="convfunction()" >
  <div  class="dropdown-content1" id='convoutput' style="width: 100%;  overflow-y: auto;">

<div class="dropdown-content"  >
    <!--<a href="userprofile.php">mansib</a> -->
  </div>


<?php



			$result = getconvpeople($id);
			if($result==true)
			{	while($row=mysqli_fetch_assoc($result))
				{
	
						$otherid=$row['sender_id'];
						
					
					$nameresult=getpersoninfo($otherid);
					$othername=mysqli_fetch_assoc($nameresult);
					
					echo "<a id='chatpeople' href='inbox.php?oid="; 
					echo $otherid; 
					echo "'>";
					echo $othername['name'];
					echo '</a>';
					echo "</br>";
				}
			}
			
		

?>




</div>
</div>
  


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

function convfunction()
{
	var idtextbox=document.getElementById('convtextbox');
	var divobj=document.getElementById('convoutput');
	
	
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
	xmlhttp.open("POST","convhandler.php?searchvalue="+idtextbox.value,true);
	xmlhttp.send();

}

    var div = document.getElementById("msgBox");
    div.scrollTop = div.scrollHeight;
	
</script>
