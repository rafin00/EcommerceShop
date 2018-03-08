<?php
    $host="localhost";
    $user="root";
    $pass="";
    $dbname="wt_project";
    
   
    function executeSQL($sql){
        global $host, $user, $pass, $dbname;
        
        $conn=mysqli_connect($host, $user, $pass, $dbname);
        $result = mysqli_query($conn, $sql);
        mysqli_close($conn);
        
        return $result;
    }
?>
