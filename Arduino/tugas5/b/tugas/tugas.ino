void setup() {
  // put your setup code here, to run once:
  Serial.begin(57600);
  pinMode(14, INPUT_PULLUP);
  pinMode(15, INPUT_PULLUP);
  pinMode(16, INPUT_PULLUP);
}

void loop() {
  // put your main code here, to run repeatedly:
  int pinA0 = digitalRead(14);
  int pinA1 = digitalRead(15);
  int pinA2 = digitalRead(16);

  if(pinA0 == LOW){
    Serial.print("0");
    }else{
      Serial.print("1");
      }

   if(pinA1 == LOW){
    Serial.print("0");
    }else{
      Serial.print("1");
      }

   if(pinA2 == LOW){
    Serial.println("0");
    }else{
      Serial.println("1");
      }

    delay(500);
}
