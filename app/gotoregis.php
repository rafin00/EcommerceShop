<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	$type=$_SESSION['type'];
	
		$myname=$_SESSION['name'];
			
			if($_SESSION['type']!='student')
		$cnr='teacherregistration.php';
	else
		$cnr='userregistration.php';
		
	
?>




<?php
$textr="";$do=false; $status=""; $filename=""; $imgname=""; $img_name=""; $file_name="";
	
	
	if($_SERVER['REQUEST_METHOD']=="POST"){
		
		if(!(empty($_REQUEST['statusbox'])))
		{	
				$status=$_REQUEST['statusbox'];
				$do=true;
		}
		else
		{
			
		}	
		
			
		
		if(!(($_FILES['photo']['name'])==""))	
		{
			$img=$_FILES['photo'];
			$img_name=$img['name'];
			$img_tmp=$img['tmp_name'];
			$img_ext=explode('.',$img_name);
			$img_ext= strtolower(end($img_ext));
			
			$imgname=uniqid().'.'.$img_ext;
			
			$img_dest= 'postimage/'.$imgname;
			move_uploaded_file($img_tmp,$img_dest);
			$do=true;
		}
		else
		{
			
		}
		
		if(!(($_FILES['file']['name'])==""))	
		{
			$file=$_FILES['file'];
			
			$file_name=$file['name'];
			$file_tmp=$file['tmp_name'];
			$file_ext=explode('.',$file_name);
			$file_ext= strtolower(end($file_ext));
			
			$filename=uniqid().'.'.$file_ext;
			
			$file_dest= 'postfile/'.$filename;
			move_uploaded_file($file_tmp,$file_dest);
			$do=true;
		}
		
		
		if($do)
		{
			$course_sec=explode('.',$_REQUEST['course']) ;
				$cs=$course_sec[1][1];
				$secs=$course_sec[0];
			addnewpost($id,$status,$imgname,$filename,$img_name,$file_name,$secs,$cs);
			header("location: userfeed.php");
				exit();
		}
		
		
	}
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
</br><a id='nav' href='logout.php?oid=""'>Logout</a> 


</div>
</td>

		<td width='75%' colspan=2 style="height: 70vh;">
		<?php 
		$isopen=issemesteropen();
		if(mysqli_num_rows($isopen)!=0)
		{
		?>
		<table width=100% border=1>
		<tr>
		<th>
		</th>
		<th>
		ID
		</th>
		<th>
		Title
		</th>
		</tr>
		<?php
		if($type=='student')
		$regisresult=getremainingcourses($id);
	else
		$regisresult=getofferedcourses();
		while($row=mysqli_fetch_assoc($regisresult))
		{  $chk='checked';
			$boxname=$row['course_id'].'_'.$row['course_name'].'_'.$row['section'];
			$res=istaken($id,$row['course_id'],$row['section']);
		if(mysqli_num_rows($res)==0||$res==false)
			{
				$chk='';
			}
		//	echo $chk;
		?>
		<tr>
		<td>
		
		<input type="checkbox" name='<?=$boxname ?>' value=1 <?=$chk?> onclick="check('<?=$boxname?>')" >
		
		</td>
		
		<td>
		<?=$row['course_id']?>
		</td>
		
		<td>
		<?=$row['course_name']?>[<?=$row['section']?>]
		</td>
		</tr>
		<?php } ?>
		</table>
		<?php } 
		else 
			echo "not allowed to register"; ?>
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

function check(boxname)
{
	var box=  document.getElementsByName(boxname)[0].checked;
	console.log(boxname);
	console.log(box);
	var val=2;
	if(box==true)
		val=1;
	console.log(val);
	
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
		      
			console.log(this.responseText);
			}
		 }
	xmlhttp.open("POST","regishandler.php?course="+boxname+"&value="+val,true);
	xmlhttp.send();
}

</script>

