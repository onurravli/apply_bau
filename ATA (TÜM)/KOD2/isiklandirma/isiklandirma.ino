#include <SPI.h>
#include "nRF24L01.h"
#include "RF24.h"
int mesaj[1];
RF24 alici(9, 10);
const uint64_t kanal = 0x415441;
int isik = A1;

void setup(void)
{
  Serial.begin(9600);
  alici.begin();
  alici.openReadingPipe(1, kanal);
  alici.startListening();
  pinMode(A2, OUTPUT);
  pinMode(A0, OUTPUT);
  pinMode(isik, OUTPUT);
  digitalWrite(A0, HIGH);
  digitalWrite(A2, LOW);
}

void loop(void) 
{
  if (alici.available())
  {
    bool done = false;
    while (!done)
    {
      done = alici.read(mesaj, 1);
      if (mesaj[0] == 123)
      {
        delay(10);
        digitalWrite(isik, LOW);
      }      
      else 
      {
        digitalWrite(isik, HIGH);
      }      
      delay(10);
    }
  }
}
