<?php require_once "../service/person_service.php"; ?>
<html>
<head>
</head>
<body>
<a href="admin.php"><h1>Welcome To Admin Panel</h1></a>
<select name="semesters" width=100% onchange="changesemester(this)">
						<?php
						$result=getallsemesters();
						
						while($row=mysqli_fetch_assoc($result))
						{
							$val=$row['sem_id'];
							$showval=$row['sem_name'];
						?>
						
						<option value="<?=$val?>"><?=$showval?>[<?=$row['status']?>]</option>
						<?php } ?>
						
					</select>
<input name="user">
<input name="ttt" type='button' value='search' onclick="getinfo()">
<div id='info'><div>

</body>
</html>


<script>

window.onload = function()
{
  a = document.getElementsByName("semesters")[0];
 
  a.selectedIndex = a.options.length-1;
    console.log(a.options[a.selectedIndex].value);
   // console.log("sds");
	
};


function changesemester(current)
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
			   document.getElementById('secresults').innerHTML=this.responseText;
			}
		 }
	xmlhttp.open("POST","secreshandler.php?sem="+selectedValue,true);
	xmlhttp.send();

}

function getinfo()
{
	 var val = document.getElementsByName('user')[0];
	 console.log(val.value);
	 a = document.getElementsByName("semesters")[0];
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
			   document.getElementById('info').innerHTML=this.responseText;
			}
		 }
	xmlhttp.open("POST","getreginfo.php?sem="+a.options[a.selectedIndex].value+"&uid="+val.value,true);
	xmlhttp.send();
}

function check(boxname)
{
	var box=  document.getElementsByName(boxname)[0].checked;
	console.log(boxname);
	console.log(box);
	console.log(id);
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
	xmlhttp.open("POST","adminregishandler.php?course="+boxname+"&value="+val+"&id="+id,true);
	xmlhttp.send();
}
function confirm()
{
	
	var val = document.getElementsByName('user')[0];
	console.log(val.value);
	
	 a = document.getElementsByName("semesters")[0];
 
 
    console.log(a.selectedIndex);
	
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
		      
			document.getElementsByName("savebutton")[0].disabled = true;
			document.getElementsByName("unsavebutton")[0].disabled = false;
			}
		 }
	xmlhttp.open("POST","adminconf.php?sem="+a.options[a.selectedIndex].value+"&uid="+val.value,true);
	xmlhttp.send();
	
	/*var val = document.getElementsByName('user')[0];
	var show document.getElementById('rstatus');
	console.log(rstatus.value);
	console.log('conf');
	console.log(val.value);
	//var val=2;
	if(box==true)
		val=1;
	console.log(val);
	
		 ;*/
}

function disconfirm()
{
	
	var val = document.getElementsByName('user')[0];
	console.log(val.value);
	
	 a = document.getElementsByName("semesters")[0];
 
 
    console.log(a.selectedIndex);
	
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
		      
			document.getElementsByName("unsavebutton")[0].disabled = true;
			document.getElementsByName("savebutton")[0].disabled = false;
			}
		 }
	xmlhttp.open("POST","adminunconf.php?sem="+a.selectedIndex+"&uid="+val.value,true);
	xmlhttp.send();
	
	/*var val = document.getElementsByName('user')[0];
	var show document.getElementById('rstatus');
	console.log(rstatus.value);
	console.log('conf');
	console.log(val.value);
	//var val=2;
	if(box==true)
		val=1;
	console.log(val);
	
		 ;*/
}
</script>