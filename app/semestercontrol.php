<?php require_once "../service/person_service.php"; ?>
<html>
<head>
</head>
<body>
<a href="admin.php"><h1>Welcome To Admin Panel</h1></a>
<?php
$result=getrunningsemester();
$msg='Currently Running Semester : None';
if(mysqli_num_rows($result)!=0)
{ echo "ff";
	$row=mysqli_fetch_assoc($result);
	$msg='Currently Running Semester : '.$row['sem_name'];
}
?>
<div id='currentsemester'><?=$msg?>
</div>

<input type='button' name='close' value='Close Current Semester' onclick="semesterclose()">
<input type='button' name='open' value='Open New Semester' onclick="newsemester()">
<input type='button' name='open' value='ReOpen Existing Semester'>
<div id='new'></div>
</body>
</html>

<script>

window.onload = function()
{
 var a = document.getElementById("currentsemester");
  console.log(a.innerHTML);
  if(a.innerHTML=='Currently Running Semester : None')
  {
	  document.getElementsByName("close")[0].disabled = true;
			   document.getElementsByName("open")[0].disabled = false;
  }
  else
  {
	  document.getElementsByName("close")[0].disabled = false;
			   document.getElementsByName("open")[0].disabled = true;
  }
};

function semesterclose()
{
	var st=document.getElementById('currentsemester');
	
	
	
	
	
	 
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
		       st.innerHTML='Currently Running Semester : None';
			   document.getElementsByName("close")[0].disabled = true;
			   document.getElementsByName("open")[0].disabled = false;
			}
		 }
	xmlhttp.open("POST","closesemester.php",true);
	xmlhttp.send();
  //
	
	 
}

function newsemester()
{
	var st=document.getElementById('new');
	st.innerHTML='Enter Semester Name : <input name="new_sem"><input type="button" value="Submit" onclick="opensemester()">';
}

function opensemester()
{
	var intr=document.getElementById('new');
	var n=document.getElementsByName('new_sem')[0];
	var st=document.getElementById('currentsemester');
	
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
		       st.innerHTML='Currently Running Semester : '+n.value; 
			   intr.innerHTML='';
			   document.getElementsByName("close")[0].disabled = false;
			   document.getElementsByName("open")[0].disabled = true;
			}
		 }
	xmlhttp.open("POST","opensemester.php?name="+n.value,true);
	xmlhttp.send();
	
}

</script>