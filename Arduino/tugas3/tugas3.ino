String dataTerima;
int nDelay = 1000;
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
pinMode(13, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
if(Serial.available() >0){
  dataTerima = Serial.readStringUntil('\n');
  nDelay = dataTerima.toInt();
  }
  digitalWrite(13, digitalRead(13) ^ 1);
  delay(nDelay);
}
