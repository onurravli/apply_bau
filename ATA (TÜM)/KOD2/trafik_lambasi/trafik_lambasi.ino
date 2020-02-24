#include  <SPI.h>
#include "nRF24L01.h"
#include "RF24.h"
int mesaj[1];
int kirmizi = 0;
int sari = 1;
int yesil = 2;
RF24 verici(9, 10);
const uint64_t kanal = 0x415441;

void setup(void)
{
  verici.begin();
  verici.openWritingPipe(kanal);
  pinMode(kirmizi, OUTPUT);
  pinMode(sari, OUTPUT);
  pinMode(yesil, OUTPUT);
}


void loop(void)
{
  mesaj[0] = 14122116122912; //kirmizi sinyali
  radio.write(mesaj, 1);
  digitalWrite(kirmizi, 1);
  delay(5000);
  digitalWrite(kirmizi, 0);
  
  mesaj[0] = 2212112; //sari
  radio.write(mesaj, 1);
  digitalWrite(sari, 1);
  delay(2000);
  digitalWrite(sari, 0);
  
  mesaj[0] = 286231115 //yesil
  radio.write(mesaj, 1);
  digitalWrite(yesil, 1);
  delay(4000);
  digitalWrite(yesil, 0);
}
