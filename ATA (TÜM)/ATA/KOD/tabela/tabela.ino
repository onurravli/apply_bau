//ATA - Tabela

#include <SPI.h>  
#include <nRF24L01.h>
#include <RF24.h>

int msg[1];
RF24 radio(9,10);
const uint64_t pipe = 0x415441;

void setup(void)
{
Serial.begin(9600);
radio.begin();
radio.openWritingPipe(pipe);
}

void loop(void)
{
msg[0] = 24126151; //tabela sinyali
radio.write(msg, 1);
}
