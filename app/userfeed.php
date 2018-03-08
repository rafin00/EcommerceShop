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
		<div id='maintable' >
		<table border=0 cellspacing="0" cellpadding="10" width='100%'>
		<tr>
		<td> Semester :
		<select name="semesters" width=100% onchange="changefeed(this)">
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
		</td>
		</tr>
		<tr>
			<td>
			
			<form method='post' enctype="multipart/form-data" > 
			Write Post : <input name='statusbox' ><font color="red"><?=$textr?></br><font color="black">
			Add photos : <input type='file' name="photo" accept="image/*" ></br>
		    Add files : <input type='file' name='file' ></br>
			
			  Post To :	<div id='postsec'>	 </div>
			<input type='submit' name='submit' value='Post'>
		<hr>	
		</form> 
			</td>
		</tr>

		<tr>
		<td>
		<div id='feedtable'> <table border=0>
		</div>
				</td>
				
				</tr>
				
				</table>
				</div>
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

function commentfunc(postid,commentid,did)
{
	var idtextbox=document.getElementsByName(commentid)[0];
	var prev=document.getElementById(did)[0];
	console.log(idtextbox.value);
	if(idtextbox.value=="")
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
		       if(document.getElementById(did).innerHTML!="")
			document.getElementById(did).innerHTML+='</br>'+this.responseText;
		else
			document.getElementById(did).innerHTML=this.responseText;
			}
		 }
	xmlhttp.open("POST","commenthandler.php?pid="+postid+"&cid="+commentid+"&text="+idtextbox.value,true);
	xmlhttp.send();
  //
	}
}
window.onload = function()
{
  a = document.getElementsByName("semesters")[0];
  var length = a.options[a.options.length];
  console.log(a.options.length);
  a.selectedIndex = a.options.length-1;
    changefeed(a);
	secdrop(a);
};

function secdrop(a)
{
	var div =document.getElementById("postsec");
	 //div.innerHTML=a.options[a.selectedIndex].value;
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
		      // console.log("here");
			  // document.getElementById('feedtable').innerHTML=this.responseText;
			  div.innerHTML=this.responseText;
			}
		 }
	xmlhttp.open("POST","secdrophandler.php?sem="+a.options[a.selectedIndex].value,true);
	xmlhttp.send();
}
function changefeed(current)
{
	 var selectedValue = current.options[current.selectedIndex].value;
	 console.log(selectedValue);
	 
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
		       console.log("here");
			   document.getElementById('feedtable').innerHTML=this.responseText;
			   secdrop(current);
			}
		 }
	xmlhttp.open("POST","feedhandler.php?sem="+selectedValue,true);
	xmlhttp.send();
  //
	
	 
}

</script>

