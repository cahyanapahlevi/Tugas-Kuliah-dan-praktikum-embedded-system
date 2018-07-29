String dataTerima;
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
pinMode(2, OUTPUT);
pinMode(3, OUTPUT);
pinMode(4, OUTPUT);
pinMode(5, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
if (Serial.available() > 0){
  dataTerima = Serial.readStringUntil('\n');

  if (dataTerima == "A"){digitalWrite(2,1);}
  if (dataTerima == "B"){digitalWrite(3,1);}
  if (dataTerima == "C"){digitalWrite(4,1);}
  if (dataTerima == "D"){digitalWrite(5,1);}

  if (dataTerima == "a"){digitalWrite(2,LOW);}
  if (dataTerima == "b"){digitalWrite(3,LOW);}
  if (dataTerima == "c"){digitalWrite(4,LOW);}
  if (dataTerima == "d"){digitalWrite(5,LOW);}
}
delay(100);
}
