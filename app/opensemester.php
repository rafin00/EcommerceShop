<?php require_once "../service/person_service.php"; ?>
<?php 

$name=$_REQUEST['name'];

opensemester($name); 
$result =getalluser();
while($row=mysqli_fetch_assoc($result))
{
	assignsemester($row['user_id']);
}
?>