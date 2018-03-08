<div align="center" >
<form method="post">
	ID:<br/><input name="id" required/><br/>
	PASSWORD:<br/><input type="password" name="password" required/><br/>
	<input type="submit"/>
</form>
</div>
<?php
	if($_SERVER['REQUEST_METHOD']=="POST"){
	$conn = mysqli_connect("localhost","root", "", "project");
		$id=$_REQUEST['id'];
		$password=$_REQUEST['password'];
		
		if($conn){
			$query="INSERT INTO users(id, password ) VALUES ($id,'$password')";
			$result = mysqli_query($conn,$query);
			if($result==true){
				echo "Record Added";
				//echo "<a href='show.php'>show</a>";
			}
		}
	}
?>
<div align="center" text="justfied">
<table border ="2" width="200"> 
<tr>
  <th>ID</th>   
  <th>PASSWORD</th> 
</tr>

</div>
<?php
	$conn = mysqli_connect("localhost","root","", "project");
	if($conn){
		$query="SELECT * FROM users";
		$result = mysqli_query($conn,$query);		
		while($row=mysqli_fetch_assoc($result)){
			$ID=$row['id'];
			$PASSWORD=$row['password'];
            
			echo"<tr align='center'>
                <td>$ID</td>
                <td>$PASSWORD</td>
            </tr>";
 
			//$EDIT="<a href='update.php?id=$row[id]'>edit</a> ";
			//$DELETE= "<a //href='delete.php?id=$row[id]'>delete</a>";
			echo "<br/>";
            
		}
	}
?>