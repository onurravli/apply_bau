<html>
<head>
<link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Poppins">
<!--<link rel="stylesheet" type="text/css" href="stil.css" />-->
<title>blodata</title>
</head>
<body>
<body bgcolor="skyblue">
<center>
<br>
<br>
<br>
<img src="img\header.png" height="54" width="238" alt="blodata logo">
<font face="Poppins">
<br>
<br>
<br>
<table border="4">
    <tr>
        <td><b>ADI SOYADI</td>
        <td><b>KAN GRUBU</td>
		<td><b>KONUM</td>
        <td><b>ILETISIM</b></td>
		<br>
    </tr>
</font>	


<?php			  
			  
$baglanti = mysqli_connect("localhost", "root", "", "blodata");
$baglanti = mysqli_connect("localhost", "root", "", "blodata");
$SQL = mysqli_query($baglanti, "SELECT * FROM veri ORDER BY adsoyad ASC");

while($dizi = mysqli_fetch_array($SQL))
{
	echo '<tr>';
	echo "<td>".$dizi['adsoyad'].'</td>';
	echo "<td>".$dizi['kangrubu'].'</td>';
	echo "<td>".$dizi['konum'].'</td>';
	echo "<td>".$dizi['iletisim'].'</td>';
	echo '</tr>';	
}

/*$adsoyad_ara = $_POST['adsoyad'];
$kangrubu_ara = $_POST['kangrubu'];
$konum_ara = $_POST['konum'];
$iletisim_ara = $_POST['iletisim'];*/

?>