<?php require_once "data_access.php"; ?>

<?php
	function searchidpass($id,$pass){
        $query = "select * from user_info where user_id='$id' and password='$pass'";
        $result = executeSQL($query);
       
			return $result;
		
    }
    function addnewpost_db($id,$status,$imgname,$filename,$img_name,$file_name,$course_sec,$cs)
	{
		$query="INSERT INTO posts(user_id, text,photo,file,photoname,filename,course_name,section) VALUES ('$id', '$status','$imgname','$filename','$img_name','$file_name','$course_sec','$cs')";     
				$result = executeSQL($query);
       
			return $result;
	}
	function getpostto_db($id,$sem)
	{
		$query="select course_name, section from registration where user_id='$id' and reg_id='$sem'";
						$result=executeSQL($query);
						return $result;
	}
	function getfeedposts_db($id,$sem)
	{
		$query="SELECT A.post_id,A.user_id,A.course_name, A.section,A.text,A.file,A.photo,A.time,A.filename,A.photoname from posts as A 
		INNER join (SELECT * from registration where user_id='$id' and reg_id='$sem' and registration.status='confirmed') as regis on A.course_name=regis.course_name and A.section=regis.section order by A.post_id desc";
						$result=executeSQL($query);
						return $result;
	}
	function getposterid_db($pid)
	{
		$query="select name from user_info where user_id=(select user_id from posts where post_id=$pid)";
						$result=executeSQL($query);
						return $result;
	}
	function getfeedcomments_db($pid2)
	{
		$query="select * from comments where post_id=$pid2";
						$result=executeSQL($query);
						return $result;
	}
	function getpersoninfo_db($comment_uid)
	{
		$query="select * from user_info where user_id=$comment_uid";
						$result=executeSQL($query);
						return $result;
	}
	function addnewmsg_db($textval,$id,$oid)
	{
		$query="insert into inbox(text,sender_id,receiver_id) values('$textval','$id','$oid')";
		$result=executeSQL($query);
		return $result;
	}
	function getconversation_db($id,$oid)
	{
		$query="SELECT * FROM inbox WHERE (sender_id=$oid and receiver_id=$id) or (sender_id=$id and receiver_id=$oid) order by msg_id asc";
		$result=executeSQL($query);
		return $result;
	}
	function getconvpeople_db($id)
	{
		$query="select DISTINCT sender_id from(
 (select (sender_id),msg_id from inbox where (not sender_id=$id) and (receiver_id=$id) ) union 
(select (receiver_id),msg_id from inbox where ( sender_id=$id) and (not receiver_id=$id) ) order by msg_id desc 
) results";
		$result=executeSQL($query);
		return $result;
	}
	
	function addnewcomment_db($pid,$id,$text)
	{
		$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
		$result=executeSQL($query);
		return $result;
	}
	function getlastcommenttime_db()
	{
		$query="select time  from comments where comment_id = (select max(comment_id) from comments)";
		$result=executeSQL($query);
		return $result;
	}
	function getsuggestions_db($id,$svalue)
	{
		$query="SELECT name,user_id from user_info where user_id = any
(
SELECT user_id from registration where 
(
course_id =
any ( SELECT course_id from registration where user_id=$id )
AND
section=
any ( SELECT section from registration where user_id=$id)
AND
    user_id <> $id
    and name like '%$svalue%'
)
)";
$result=executeSQL($query);
		return $result;
	}
	function searchconv_db($id,$text)
	{
		$query="select name,user_id from user_info where user_id= any (select DISTINCT sender_id from(
 (select (sender_id),msg_id from inbox where (not sender_id=$id) and (receiver_id=$id) ) union 
(select (receiver_id),msg_id from inbox where ( sender_id=$id) and (not receiver_id=$id) ) order by msg_id desc 
) results )
and name like '%$text%'";
$result=executeSQL($query);
		return $result;
	}
	function  getreginfo_db($id,$sem)
	{
		$query="SELECT * FROM registration where user_id='$id' and reg_id='$sem'";
$result=executeSQL($query);
		return $result;
	}
	function setnewpassword_db($id,$newpass)
	{
		$query="UPDATE user_info
SET password='$newpass'
WHERE user_id='$id';";
$result=executeSQL($query);
		return $result;
	}
	function getofferedcourses_db()
	{
		$query="
SELECT sections.course_id,sections.section,sections.capacity,sections.count, courses.course_name
FROM sections , courses
where sections.course_id=courses.course_id";
$result=executeSQL($query);
		return $result;
	}
	function getsections_db($id)
	{
		$query="select * from registration where user_id='$id'";
$result=executeSQL($query);
		return $result;
	}
	function getstudents_db($course,$section,$sem)
	{
		$query="select registration.*,user_info.name from registration , user_info where course_id='$course' and section='$section' and reg_id='$sem' and registration.user_id=user_info.user_id and user_info.type <>'teacher'";
$result=executeSQL($query);
		return $result;
	}
	function addnewuser_db($id,$name,$type,$email,$status,$password,$imgname)
	{
		$query="INSERT INTO user_info ( user_id,name, photo, type, email, status,  password) VALUES ( '$id','$name', '$imgname','$type','$email', '$status', '$password')";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function  istaken_db($id,$course_id,$section)
	{
		$query="select user_id from registration where course_id='$course_id' and section='$section' and user_id='$id' and reg_id=(select sem_id from semesters where status='open')";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function  addtoregis_db($id,$course_id,$course_name,$section)
	{
		$query="insert into registration(user_id,course_id,course_name,section,status,reg_id) values('$id','$course_id','$course_name','$section','notconfirmed',(select sem_id from semesters where status='open'))";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text','notconfirmed');";
$result=executeSQL($query);
		return $result;
	}
	function removefromregis_db($id,$course_id,$course_name,$section)
	{
		$query="delete from registration where user_id='$id' and course_id='$course_id' ";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function addnewcourse_db($name)
	{
		$query="INSERT INTO `wt_project`.`courses` (`course_id`, `course_name`) VALUES (NULL, '$name')";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function addnewsection_db($courseId,$secName,$capacity)
	{
		$query="INSERT INTO `wt_project`.`sections` (`course_id`, `section`, `capacity`, `count`) VALUES ('$courseId', '$secName', '$capacity', '')";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function deleteuser_db($id)
	{
		$query="DELETE FROM user_info WHERE user_id='$id'";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function getalluserinfo_db()
	{
		$query="SELECT * FROM user_info";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function updateuser_db($email,$status,$password,$id)
	{
		$query="UPDATE `user_info` SET `email` = '$email', `status` = '$status', `password` = '$password' WHERE `user_info`.`user_id` = '$id'";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function assigngrade_db($course_id,$section,$user_id,$grade,$sem)
	{
		$query="UPDATE `registration` SET grade= '$grade' WHERE user_id='$user_id' and course_id='$course_id' and section = '$section' and reg_id='$sem' and status='confirmed' ";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function getsemesters_db($id)
	{
		$query="select DISTINCT(registration.reg_id),semesters.sem_name from registration,semesters where registration.user_id='$id' and registration.reg_id=semesters.sem_id and semesters.status='closed'  order by reg_id asc ";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function getcourses_db($id,$sem)
	{
		$query="select * from registration where user_id='$id' and reg_id='$sem' and status='confirmed'";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function getremainingcourses_db($id)
	{
		$query="
 select A.*,courses.course_name from (
select * from sections where course_id <> all (SELECT DISTINCT (course_id) from registration where 
grade <> 'F' and status='confirmed' and user_id='$id') ) A,courses where A.course_id=courses.course_id";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}function getremainingcoursesad_db($id)
	{
		$query="
 select A.*,courses.course_name from (
select * from sections where course_id <> all (SELECT DISTINCT (course_id) from registration where 
grade <> 'F' and status='confirmed' and user_id='$id') ) A,courses where A.course_id=courses.course_id";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function getrunningsemesterad_db()
	{
		$query="select * from semesters where status='open'";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function  closesemester_db()
	{
		$query="UPDATE `semesters` SET `status`='closed' WHERE status='open'";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function  opensemester_db($name)
	{
		$query="insert into semesters(sem_name,status) values('$name','open')";
		
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		
			
		return $result;
	}
	function  getallsemesters_db()
	{
		$query="select * from semesters";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function  isconfirmed_db($sem,$id)
	{
		$query="select * from user_semesters where user_id='$id' and sem_id='$sem'";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
		return $result;
	}
	function  confirmreg_db($uid,$sem)
	{
		$query="update user_semesters set status='confirmed' where sem_id='$sem' and user_id='$uid'";
		$query1="update registration set status='confirmed' where reg_id='$sem' and user_id='$uid'";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
$result=executeSQL($query1);
		return $result;
	}
	function  unconfirmreg_db($uid,$sem)
	{
		$query="update user_semesters set status='unconfirmed' where sem_id='$sem' and user_id='$uid'";
		$query1="update registration set status='unconfirmed' where reg_id='$sem' and user_id='$uid'";
				//$query="INSERT INTO comments ( post_id, commenter_id,text) VALUES ('$pid','$id', '$text');";
$result=executeSQL($query);
$result=executeSQL($query1);
		return $result;
	}
	function  isopen_db($sem)
	{
		$query="select * from semesters where sem_id='$sem'";
$result=executeSQL($query);
		return $result;
	}
	function  getregisterdcourses_db($sem,$id)
	{
		$query="select * from registration where reg_id='$sem' and user_id='$id'";
$result=executeSQL($query);
		return $result;
	}
	function   getalluser_db()
	{
		$query="select * from user_info";
$result=executeSQL($query);
		return $result;
	}
	function   assignsemester_db($id)
	{
		$query="insert into user_semesters(sem_id,status,user_id) values((select sem_id from semesters where status='open'),'notconfirmed','$id')";
$result=executeSQL($query);
		return $result;
	}
	function   issemesteropen_db()
	{
		$query="select * from semesters where status='open'";
$result=executeSQL($query);
		return $result;
	}
	
?>