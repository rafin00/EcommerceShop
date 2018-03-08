<?php require_once "../service/person_service.php"; ?>
<?php
	session_start();
	if(isset($_SESSION['id'])==false){
		header("location: login.php");
	}
	$id=$_SESSION['id'];
	
	$sem=$_REQUEST['sem'];
	//
	
	 $result=getfeedposts($id,$sem);
		    
				if($result==true)
				{
				
				while($row=mysqli_fetch_assoc($result))
				{ 
			$pid=$row['post_id'];
			     $nam=getposterid($pid);
					
				
				$name=mysqli_fetch_assoc($nam);
		
	?>
	<table border=0 width=100%>
		<tr >
			<td><a  href="userprofile.php?var_id=<?=$row['user_id']?>"><?=$name['name']?></a> <?=$row['course_name']?>[<?=$row['section']?>]</td>
			
		</tr>
		<tr>
			<td><?=$row['text']?></td>
			
		</tr>
		
		<tr>
			<td>
			<a href="postfile/<?=$row['file']?>"><?=$row['filename']?></a>
			</td>
			
		</tr>
		
		
		<tr>
			<td> 
			<?php if(!($row['photo'])=="") { ?>
			<img src="postimage/<?=$row['photo']?>" width=300 alt="">
			<?php } ?>
			</td>
			
		</tr>
		
		<tr align='right'>
			<td>
			<?=$row['time']?>
			<hr>
			</td>
		</tr>
		
		<tr align='left'>
			<td>
			
			
			
			<input name='comment.<?=$row['post_id']?>'>     
		    
			<input type='Button' value="Comment" onclick="commentfunc('<?=$row['post_id']?>','comment.<?=$row['post_id']?>','id.<?=$row['post_id']?>')">
			
			 
			</td> 
		</tr>
		<tr>
		<td>
		<?php 
		
		$result1=getfeedcomments($row['post_id']);
		
	
				if($result1==true)
				{
					
					
				
					while($crow=mysqli_fetch_assoc($result1))
					{
						
						$comment_uid=$crow['commenter_id'];
						$n=getpersoninfo($comment_uid);
					
					$cname=mysqli_fetch_assoc($n);
		
		?>
			<p id='comments' ><a  href="userprofile.php?var_id=<?=$cname['user_id']?>"><?=$cname['name']?></a>
			 <?=$crow['text']?></br>
			 <small><?=$crow['time']?></small>
</p>			 
		
				<?php }}  ?>
				<p id='id.<?=$row['post_id']?>'></p>
				<hr>
				</td>
		</tr>
		
		
				<?php 
				}
				}				?>
				</table>
	
	
//
			

