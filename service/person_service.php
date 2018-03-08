<?php require_once "../data/person_data_access.php"; ?>
<?php

	


function isvalididpass($id,$pass){
        return searchidpass($id,$pass);
    }
	
	function addnewpost ($id,$status,$imgname,$filename,$img_name,$file_name,$course_sec,$cs){
        return addnewpost_db($id,$status,$imgname,$filename,$img_name,$file_name,$course_sec,$cs);
    }
	function getpostto($id,$sem)
	{
		return getpostto_db($id,$sem);
    }
	
	function getfeedposts($id,$sem)
	{
		return getfeedposts_db($id,$sem);
	}	
	function getposterid($pid)
	{
		return getposterid_db($pid);
	}
	function getfeedcomments($pid2)
	{
		return getfeedcomments_db($pid2);
	}
	function getpersoninfo($comment_uid)
	{
		return getpersoninfo_db($comment_uid);
	}
	function addnewmsg($textval,$id,$oid)
	{
		return addnewmsg_db($textval,$id,$oid);
	}
	function getconversation($id,$oid)
	{
		return getconversation_db($id,$oid);
	}
	function  getconvpeople($id)
	{
		return  getconvpeople_db($id);
	}
	function  addnewcomment($pid,$id,$text)
	{
		return  addnewcomment_db($pid,$id,$text);
	}
	function  getlastcommenttime()
	{
		return  getlastcommenttime_db();
	}
	function  getsuggestions($id,$svalue)
	{
		return   getsuggestions_db($id,$svalue);
	}
	function  searchconv($id,$text)
	{
		return   searchconv_db($id,$text);
	}
	function   getreginfo($id,$sem)
	{
		return    getreginfo_db($id,$sem);
	}
	function   setnewpassword($id,$newpass)
	{
		return    setnewpassword_db($id,$newpass);
	}
	function   getofferedcourses()
	{
		return    getofferedcourses_db();
	}
	function   getsections($id)
	{
		return    getsections_db($id);
	}
	function  getstudents($course,$section,$sem)
	{
		return   getstudents_db($course,$section,$sem);
	}
	function  addnewuser($id,$name,$type,$email,$status,$password,$imgname)
	{
		return   addnewuser_db($id,$name,$type,$email,$status,$password,$imgname);
	}
	function  istaken($id,$course_id,$section)
	{
		return   istaken_db($id,$course_id,$section);
	}
	function  addtoregis($id,$course_id,$course_name,$section)
	{
	return   addtoregis_db($id,$course_id,$course_name,$section);
	}
	function  removefromregis($id,$course_id,$course_name,$section)
	{
	return   removefromregis_db($id,$course_id,$course_name,$section);
	}
	function  addnewcourse($name)
	{
	return  addnewcourse_db($name);
	}
	function  addnewsection($courseId,$secName,$capacity)
	{
	return  addnewsection_db($courseId,$secName,$capacity);
	}
	function  deleteuser($id)
	{
	return  deleteuser_db($id);
	}
	function getalluserinfo()
	{
	return  getalluserinfo_db();
	}
	function updateuser($email,$status,$password,$id)
	{
	return  updateuser_db($email,$status,$password,$id);
	}
	function assigngrade($course_id,$section,$user_id,$grade,$sem)
	{
	return  assigngrade_db($course_id,$section,$user_id,$grade,$sem);
	}
	function getsemesters($id)
	{
	return  getsemesters_db($id);
	}
	function getcourses($id,$sem)
	{
	return  getcourses_db($id,$sem);
	}	
	function getremainingcourses($id)
	{
	return  getremainingcourses_db($id);
	}function getremainingcoursesad($id)
	{
	return  getremainingcoursesad_db($id);
	}
	function getrunningsemester()
	{
	return  getrunningsemesterad_db();
	}
	function closesemester()
	{
	return  closesemester_db();
	}
	function opensemester($name)
	{
	return  opensemester_db($name);
	}
	function getallsemesters()
	{
	return  getallsemesters_db();
	}
	function isconfirmed($sem,$id)
	{
	return  isconfirmed_db($sem,$id);
	}
	function confirmreg($uid,$sem)
	{
	return  confirmreg_db($uid,$sem);
	}
	function unconfirmreg($uid,$sem)
	{
	return  unconfirmreg_db($uid,$sem);
	}
	function isopen($sem)
	{
	return  isopen_db($sem);
	}
	function getregisterdcourses($sem,$id)
	{
	return  getregisterdcourses_db($sem,$id);
	}
	function getalluser()
	{
	return  getalluser_db();
	}
	function assignsemester($id)
	{
	return  assignsemester_db($id);
	}
	function issemesteropen()
	{
	return  issemesteropen_db();
	}
	
?>