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
			  mail('onurravli@hotmail.com', 'blodata Kayit', $message,$headers);
			  $link = mysqli_connect("mysql.hostinger.web.tr", "u864531356_db", "ravlionur2001", "u864531356_db");
			  if($link === false){
			  die("HATA: " . mysqli_connect_error());
				}
				$adsoyad = mysqli_real_escape_string($link, $_POST['adsoyad']);
				$kangrubu = mysqli_real_escape_string($link, $_POST['kangrubu']);
				$eposta = mysqli_real_escape_string($link, $_POST['eposta']);
				$konum = mysqli_real_escape_string($link, $_POST['konum']);
				$iletisim = mysqli_real_escape_string($link, $_POST['iletisim']);
				$sql = "INSERT INTO veri (adsoyad, telefon, eposta,sehir,adres,yardim) VALUES ('$adsoyad', '$telefon', '$eposta', '$sehir', '$adres', '$yardim')";
				if(mysqli_query($link, $sql)){
				echo '<center>
				<body bgcolor="4298f4"> <font face="Poppins" color="fffff">Kaydınız alınmıştır, teşekkürler. Yönlendiriliyorsunuz.</font></center>';
				} 	
			else
				{
			echo '<center>
			<body bgcolor="4298f4"><center>';
			echo "HATA: $sql. " . mysqli_error($link);
				}
			mysqli_close($link);
			}
?>
<html>
	<head>
		<title>
		blodata
		</title>
		<meta http-equiv="refresh" content="3; url=\">
	</head>
</html>