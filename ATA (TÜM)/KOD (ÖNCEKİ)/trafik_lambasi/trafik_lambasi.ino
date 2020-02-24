//ATA - Trafik Lambası
//Dijital 0, 1 ve 2. pinlerde sırasıyla kırmızı, sarı ve yeşil ledler bağlı.

#include <SPI.h>  
#include <nRF24L01.h>
#include <RF24.h>

int msg[1];
int kirmizi = 0;
int sari = 1;
int yesil = 2;
RF24 radio(9,10);
const uint64_t pipe = 0x415441;

void setup(void)
{
Serial.begin(9600);
radio.begin();
radio.openWritingPipe(pipe);
pinMode(kirmizi, OUTPUT);
pinMode(sari, OUTPUT);
pinMode(yesil, OUTPUT);
}

void loop(void)
{
msg[0] = 14122116122912; //kirmizi sinyali
radio.write(msg, 1);
digitalWrite(kirmizi, 1);
delay(5000);
msg[0] = 2212112; //sari
radio.write(msg, 1);
digitalWrite(sari, 1);
delay(2000);
msg[0] = 286231115 //yesil
radio.write(msg, 1);
digitalWrite(yesil, 1);
delay(4000);
}

//Tamamlandı: 9 Eylül 2018
