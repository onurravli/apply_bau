<?php
			  $message =  
			  "AD SOYAD:".$_POST['adsoyad'].
			  "KAN GRUBU:".$_POST['kangrubu'].
			  "KONUM:".$_POST['konum'].
			  "ILETISIM:".$_POST['iletisim'];
			  $headers =  'MIME-Version: 1.0' . "\r\n"; 
			  $headers .= 'From: Blodata <blodata@blodata.com>' . "\r\n";
			  $headers .= 'Content-type: text/html; charset=iso-8859-1' . "\r\n"; 
				if (empty($_POST['adsoyad']) or empty($_POST['kangrubu']) or empty($_POST['konum']) or empty($_POST['iletisim']))
				{
				echo '
				<link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Poppins">
				<html>
				<link rel="stylesheet" type="text/css" href="style.css" />
				<font face="Poppins">Lutfen tum alanlari doldurunuz.
				<body bgcolor="skyblue"><meta http-equiv="refresh" content="3;url=\">';
				}
				else
				{
			  //mail('onurravli@hotmail.com', 'blodata Kayit', $message,$headers);
			  $link = mysqli_connect("localhost", "root", "", "blodata");
			  if($link === false){
			  die("HATA: " . mysqli_connect_error());
				}
				$adsoyad = mysqli_real_escape_string($link, $_POST['adsoyad']);
				$kangrubu = mysqli_real_escape_string($link, $_POST['kangrubu']);
				//$eposta = mysqli_real_escape_string($link, $_POST['eposta']);
				$konum = mysqli_real_escape_string($link, $_POST['konum']);
				$iletisim = mysqli_real_escape_string($link, $_POST['iletisim']);
				$sql = "INSERT INTO veri (adsoyad, kangrubu, konum, iletisim) VALUES ('$adsoyad', '$kangrubu', '$konum', '$iletisim')";
				if(mysqli_query($link, $sql)){
				echo '<center>
				<br>
				<br>
				<br>
				<body bgcolor="skyblue"> <script> alert("Bilgileriniz alındı, teşekkürler! Yönlendiriliyorsunuz."); </script></center>';
				} 	
			else
				{
			echo '<center>
			<body bgcolor="skyblue"><center>';
			echo "HATA: $sql. " . mysqli_error($link);
				}
			mysqli_close($link);
			}
?>
<html>
	<head>
	<body bgcolor="skyblue"/>
		<title>
		blodata
		</title>
		<meta http-equiv="refresh" content="1; url=\">
	</head>
</html>