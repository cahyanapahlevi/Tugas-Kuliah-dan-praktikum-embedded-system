String dataTerima ="off";
int nPWM;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(13, OUTPUT); 
  
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available() >0){
  dataTerima = Serial.readStringUntil('\n');
  nPWM = dataTerima.toInt();
  
  analogWrite(9, nPWM);
  }
}
