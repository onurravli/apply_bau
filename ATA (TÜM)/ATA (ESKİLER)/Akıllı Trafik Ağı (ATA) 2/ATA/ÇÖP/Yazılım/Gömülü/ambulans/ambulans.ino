#include  <SPI.h> 
#include "nRF24L01.h"
#include "RF24.h"
int ambulans[1];
RF24 verici(9,10);
const uint64_t kanal = 0x415441;

void setup(void)
{
 verici.begin();
 verici.openWritingPipe(kanal);
}

void loop(void)
{
 ambulans[0] = 01100001; 
 verici.write(01100001, 1);
}
