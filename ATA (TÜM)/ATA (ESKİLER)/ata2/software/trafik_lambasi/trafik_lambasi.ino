#include  <SPI.h> 
#include "nRF24L01.h"
#include "RF24.h"
int kirmizi[1];
int sari[1];
int yesil[1];
RF24 verici(9,10);
const uint64_t kanal = 0x415441;

void setup(void)
{
 verici.begin();
 verici.openWritingPipe(kanal);
}

void loop(void)
{
 kirmizi[0] = 111; 
 verici.write(kirmizi, 1);
 delay(5000); 
 sari[0] = 222; 
 verici.write(sari, 1);
 delay(1000);
 yesil[0] = 333; 
 verici.write(yesil, 1);
 delay(5000);
 sari[0] = 222; 
 verici.write(sari, 1);
 delay(1000); 
}
