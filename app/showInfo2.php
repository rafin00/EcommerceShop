<?php require_once "../service/person_service.php"; ?>
<html>
<head>
<style>

table, th, td {
    border: 1px solid #ddd;
    border-collapse: collapse;
	text-align: center;	
}

th, td {
    padding: 10px;
}
th {
    text-align: center;
}

a{
	text-decoration: none;
	color: black;
}
</style>
</head>
<body>
<div align='center'>
<a href="admin.php"><h1>Welcome To Admin Panel</h1></a>
  <a href="logout.php" style="width=10%"><input style="
   
    top: 30px;
    right: 20px;
    width: 115px;
	padding: 4px 0px 5px 0px;
" class="button " type="button" value="Logout" /></a>
</div>


<form action="" style="text-align: -webkit-center;" >

		<?php
			
				//$query="SELECT * FROM user_info";
				//$result = mysqli_query($conn,$query);
				$result=getalluserinfo();
				echo "<table >";
				echo "<tr>"."<th>"."User ID"."</th>"."<th>"."NAME"."</th>"."<th>"."TYPE"."</th>"."<th>"."EMAIL"."</th>"."<th>"."STATUS"."</th>"."<th>"."PASSWORD"."</th>"."<th>"." "."</th>"."</tr>";
				
				while($row=mysqli_fetch_assoc($result)){
					echo "<tr>";
				echo '<td>'.$row['user_id'].'</td>'.'<td>'.$row['name'].'</td>'.'<td>'.$row['type'].'</td>'.'<td>'.$row['email'].'</td>'.'<td>'.$row['status'].'</td>'.'<td>'.$row['password'].'</td>'.'<td>'.'<button><a href="delete.php?id='.$row['user_id'].'">Delete</a></button>'.'</td>';
					echo "</tr>";

				}
				echo "</table>";
			
		?>


</form>
</body>
</html>
