String dataTerima;
long bil1, bil2, bil3;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(57600);
}

void loop() {
  // put your main code here, to run repeatedly:
  bil1 = random(0,256);
  bil2 = random(0,256);
  //bil3 = random(0,256);
  bil3+=10; if (bil3>255) {bil3 = 0;}
  Serial.print("A");
  Serial.print(bil1);
  Serial.print("B");
  Serial.print(bil2);
  Serial.print("C");
  Serial.print(bil3);
  Serial.println("D");

  delay(300);
}
