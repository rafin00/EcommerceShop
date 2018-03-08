<?php require_once "../service/person_service.php"; ?>
<?php
	$inv="";
	$cnv="";
	if($_SERVER['REQUEST_METHOD']=="POST"){
		
		if(isset($_POST["submit1"])){
			//echo $_REQUEST["secName"];
			
			$name = $_POST['cname'];
			
				
				//$query="INSERT INTO `wt_project`.`courses` (`course_id`, `course_name`) VALUES (NULL, '$name')";
				
				//$result = mysqli_query($conn,$query);
				$result = addnewcourse($name);
				
				if($result==true){
					$inv="Course Added ";
					//header("location: addCourses&Section.php");
					
				}
			
		} 

		if(isset($_POST["submit2"]) ){
			//echo $_REQUEST["secName"];
			
			$courseId = $_POST["courseId"];
			$secName = $_POST["secName"];
			$capacity = $_POST["capacity"];
				
				//$query="INSERT INTO `wt_project`.`sections` (`course_id`, `section`, `capacity`, `count`) VALUES ('$courseId', '$secName', '$capacity', '')";
				
				//$result = mysqli_query($conn,$query);
				
				$result=addnewsection($courseId,$secName,$capacity);
				if($result==true){
					$inv="section Added ";
					//header("location: addCourses&Section.php");
					
				}
			
		}
		
		
		
	}

?>	
	
<!DOCTYPE HTML>
<html lang="en-US">
<head>
	<style type="text/css">
	
	
	
	body select { display: block; padding: 10px 70px 10px 13px !important; max-width: 100%; height: auto !important; border: 1px solid #e3e3e3; border-radius: 3px; background: url("selectbox_arrow.png") right center no-repeat; background-color: #fff; color: #444444; font-size: 12px; line-height: 16px !important; appearance: none; 
	/* this is must */ -webkit-appearance: none; -moz-appearance: none; } 
	/* body select.select_box option */
	body select option { padding: 0 4px; }
	/* for IE and Edge */ 
	select::-ms-expand { display: none; } select:disabled::-ms-expand { background: #f60; }

	
	
	
	
.form {
  position: relative;
  z-index: 1;
  background: #FFFFFF;
  max-width: 49%;
  margin: 0 auto 100px;
  padding: 30px;
  border-top-left-radius: 3px;
  border-top-right-radius: 3px;
  border-bottom-left-radius: 3px;
  border-bottom-right-radius: 3px;
  text-align: center;
}
.form .thumbnail {
  background: #EF3B3A;
  width: 150px;
  height: 150px;
  margin: 0 auto 30px;
  padding: 30px 30px;
  border-top-left-radius: 100%;
  border-top-right-radius: 100%;
  border-bottom-left-radius: 100%;
  border-bottom-right-radius: 100%;
  box-sizing: border-box;
}
.form .thumbnail img {
  display: block;
  width: 100%;
}
.form input {
  outline: 0;
  background: #f2f2f2;
  width: 100%;
  border: 0;
  margin: 0 0 15px;
  padding: 15px;
  border-top-left-radius: 3px;
  border-top-right-radius: 3px;
  border-bottom-left-radius: 3px;
  border-bottom-right-radius: 3px;
  box-sizing: border-box;
  font-size: 14px;
}
.form .button {
  outline: 0;
  background: #EF3B3A;
  width: 100%;
  border: 0;
  padding: 15px;
  border-top-left-radius: 3px;
  border-top-right-radius: 3px;
  border-bottom-left-radius: 3px;
  border-bottom-right-radius: 3px;
  color: #FFFFFF;
  font-size: 14px;
  -webkit-transition: all 0.3 ease;
  transition: all 0.3 ease;
  cursor: pointer;
}
.container {
  position: relative;
  z-index: 1;
  max-width: 31%;
  margin: 0 auto;
}
.container:before, .container:after {
  content: "";
  display: block;
  clear: both;
}
.container .info {
  margin: 50px auto;
  text-align: center;
}
.container .info h1 {
  margin: 0 0 15px;
  padding: 0;
  font-size: 36px;
  font-weight: 300;
  color: #1a1a1a;
}
.container .info span {
  color: #4d4d4d;
  font-size: 12px;
}
.container .info span a {
  color: #000000;
  text-decoration: none;
}
.container .info span .fa {
  color: #EF3B3A;
}
.logoutBTN {
	width: 12%;
    padding: 3px;
}
body {
  background: #ccc;
  font-family: "Roboto", sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}
body:before {
  content: "";
  position: fixed;
  top: 0;
  left: 0;
  display: block;
  background: rgba(255, 255, 255, 0.8);
  width: 100%;
  height: 100%;
}
  </style>	
		
</head>
<body>
<div class="container">
  <div class="info">
    <a href="admin.php"><h1>Welcome To Admin Panel</h1></a>
  </div>
</div>
		
<div class="form">
	<a href="logout.php" style="width=10%"><input style="
    position: relative;
    position: absolute;
    top: 15px;
    right: 30px;
    width: 115px;
	padding: 4px 0px 5px 0px;
" class="button " type="button" value="Logout" /></a>
	
	<form class="login-form" style="text-align: -webkit-center" method="post" name="form1" >
	
		Course Name: <input type="text" name="cname"/>

		<input class="button" type="submit" value="Add" name="submit1"/>
		
	</form>


	
	<form class="login-form" style="text-align: -webkit-center" method="post" name="form2" >
	<tr>
	
		<td>
		
			Course ID: <select name="courseId">
						
						<?php
						$conn = mysqli_connect("localhost","root", "", "wt_project");
						if($conn){
						$query="SELECT * FROM `courses`";
						
						$result=mysqli_query($conn,$query);
						
						while($row=mysqli_fetch_assoc($result))
						{
							$val=$row['course_id'];
						
						?>
						
						<option value="<?=$val?>"><?=$val?></option>
						<?php } }?>
						
						</select>
						
		</td>
		
	</tr>
	Section name: <input type="text" name="secName" style="width: 100%;" />
	
	Capacity: <input type="text" name="capacity" />
	
	<input class="button" type="submit" value="Add section"name="submit2"  />
	
</form>	

<font color="red"> <?=$inv?></font>
</div>
</body>
</html>