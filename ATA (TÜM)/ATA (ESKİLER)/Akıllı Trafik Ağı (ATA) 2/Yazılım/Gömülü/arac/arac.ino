#include <SPI.h>
#include "nRF24L01.h"
#include "RF24.h"
int mesaj[1];
RF24 alici(9, 10);
const uint64_t kanal = 0x415441;

void setup(void) 
{
	Serial.begin(9600);
	alici.begin();
	alici.openReadingPipe(1, kanal);
	alici.startListening();
}

void loop(void) {
	if (alici.available())
	{
		bool done = false;
		while (!done)
		{
			done = alici.read(mesaj, 1);

			if (mesaj[0] == 01100001)
			{
				//arac
			}
			if (mesaj[0] == 01101011)
      {
        //kirmizi
      }
      if (mesaj[0] == 01110011)
      {
        //sari
      }
      if (mesaj[0] == 01111001)
      {
        //yesil
      }
      if (mesaj[0] == 01110100)
      {
        //tabela
      }
			delay(10);
		}
	}
}
