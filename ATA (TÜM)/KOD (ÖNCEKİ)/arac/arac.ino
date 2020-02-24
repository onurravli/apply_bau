//ATA - Araç

#include <Wire.h> 
#include <LiquidCrystal_I2C.h> 
#include <SPI.h>
#include <nRF24L01.h>
#include <RF24.h>
LiquidCrystal_I2C lcd(0x27, 16, 2);

int msg[1];
RF24 radio(9,10);
RF24 radio2(9,10);
const uint64_t pipe = 0x415441;
const uint64_t pipe2 = 0x4154412;
int buzzer = A3;

void setup(void)
{
lcd.init();
lcd.backlight();
Serial.begin(9600);
radio.begin();
radio.openReadingPipe(1, pipe);
radio2.openReadingPipe(1, pipe);
radio.startListening();
radio2.startListening();
pinMode(buzzer, OUTPUT);
}

void loop(void)
{
lcd.setCursor(1,0);
lcd.print("TEKNOFEST IST.");

msg[0] =  12114; //arac sinyali
radio2.write(msg, 1);

if (radio.available())
{
bool done = false;
while (!done)
{
done = radio.read(msg, 1);
Serial.println(msg[0]);
if (msg[0] == 1162251511722)
{
  ambulans: 

  lcd.write("Bulundugunuz konumda ambulans var.");
  digitalWrite(buzzer, HIGH);
  delay(50);
  digitalWrite(buzzer, LOW);
  delay(50);
  delay(1000);
  if(msg[0] == 1162251511722)
  {
    goto ambulans;
  }
  else
  {
    lcd.clear();
    digitalWrite(buzzer, LOW);
  }
  //ambulans sinyali gelince yapilacaklar.
  //Ekranda ve Buzzerda uyarı olacak
}

else if(msg[0] == 24126151)
{
  tabela:
  //tabela sinyali gelince yapilacaklar.
  //Ekranda ve Buzzerda bilgilendirme olacak  
  lcd.write("Bulundugunuz konumda null tabela var.");
  digitalWrite(buzzer, HIGH);
  delay(50);
  digitalWrite(buzzer, LOW);
  delay(50);
  delay(1000);
  if(msg[0] == 24126151)
  {
    goto tabela;
  }
  else
  {
    lcd.clear();
    digitalWrite(buzzer, LOW);
  }
}

else if(msg[0] == 14122116122912)
{
  kirmizi:
  lcd.write("Bulundugunuz konumda kirmizi isik var.");
  digitalWrite(buzzer, HIGH);
  delay(50);
  digitalWrite(buzzer, LOW);
  delay(50);
  delay(1000);
  if(msg[0] == 14122116122912)
  {
    goto kirmizi;
  }
  else
  {
    lcd.clear();
    digitalWrite(buzzer, LOW);
  }
}

else if(msg[0] == 2212112)
{
  sari:
  lcd.write("Bulundugunuz konumda sari isik var.");
  digitalWrite(buzzer, HIGH);
  delay(50);
  digitalWrite(buzzer, LOW);
  delay(50);
  delay(1000);
  if(msg[0] == 2212112)
  {
    goto sari;
  }
  else
  {
    lcd.clear();
    digitalWrite(buzzer, LOW);
  }
}

else if(msg[0] == 286231115)
{
  yesil:
  lcd.write("Bulundugunuz konumda yesil isik var.");
  digitalWrite(buzzer, HIGH);
  delay(50);
  digitalWrite(buzzer, LOW);
  delay(50);
  delay(1000);
  if(msg[0] == 2212112)
  {
    goto yesil;
  }
  else
  {
    lcd.clear();
    digitalWrite(buzzer, LOW);
  }
}
}
}
else
{
Serial.println("Iletisim kurulamadi.");
lcd.write("Iletisim Kurulamadi");
}
}
