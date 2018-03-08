<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	$sem=$_REQUEST['semester'];
	$info=$_REQUEST['info'];
	$infos=explode('_',$info);
	$grade=$_REQUEST['grade'];
	echo $grade.'_';
	//echo $infos[0].$infos[1].$infos[2].$grade;
			$result= assigngrade($infos[0],$infos[1],$infos[2],$grade,$sem);
			/*if($result==true)
			{	$row=mysqli_fetch_assoc($result);
		$myname=$row['name'];
			}

		
			
			addnewcomment($pid,$id,$text);

			$result = getlastcommenttime();
			$row=mysqli_fetch_assoc($result);
			

		echo '<p id="comments"><a  href="userprofile.php?var_id='.$id.'">'.$myname.'</a> '.$text.'</br><small>('.$row['time'].')</p></small>';
		*/
	
?>

