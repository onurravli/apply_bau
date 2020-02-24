//ATA - Işıklandırma

#include <SPI.h>
#include <nRF24L01.h>
#include <RF24.h>
int msg[1];
int isiklandirma = A4;
RF24 radio(9,10);
const uint64_t pipe = 0x415441;

void setup(void)
{
Serial.begin(9600);
radio.begin();
radio.openReadingPipe(1,pipe);
radio.startListening();
pinMode(isiklandirma, OUTPUT);
}

void loop(void)
{
if (radio.available())
{
bool done = false;
while (!done)
{
done = radio.read(msg, 1);
Serial.println(msg[0]);
if (msg[0] == 12114)
{
//Arac varken yapilacaklar.
digitalWrite(isiklandirma, LOW);
}
else 
{
//Arac yokken yapilacaklar.
digitalWrite(isiklandirma, HIGH);
}
delay(10);
}
}
else
{
Serial.println("No radio available");
}
}
