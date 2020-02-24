#include <SPI.h>
#include "nRF24L01.h"
#include "RF24.h"
int mesaj[1];
int isiklar = A0;
RF24 alici(9, 10);
const uint64_t kanal = 0x415441;
void setup(void)
{
  Serial.begin(9600);
  alici.begin();
  alici.openReadingPipe(1, kanal);
  alici.startListening();
  pinMode(isiklar, OUTPUT);
}

void loop(void)
{
  if (alici.available())
  {
    bool done = false;
    while (!done)
    {
      done = alici.read(mesaj, 1);
      if (mesaj[0] == 01101011)
      {
        digitalWrite(isiklar, 0);
      }
      else
      {
        digitalWrite(isiklar, 1);
      }
      delay(10);
    }
  }
}
