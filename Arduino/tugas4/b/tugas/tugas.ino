String dataTerima;

int nA, nB, nC, nD;
String sPWM1, sPWM2, sPWM3;
int nPWM1, nPWM2, nPWM3;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(13, OUTPUT);

}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available() >0) {
    dataTerima = Serial.readStringUntil('\n');

    nA = dataTerima.indexOf("A");
    nB = dataTerima.indexOf("B");
    nC = dataTerima.indexOf("C");
    nD = dataTerima.indexOf("D");

    sPWM1 = dataTerima.substring(nA+1,nB);
    sPWM2 = dataTerima.substring(nB+1,nC);
    sPWM3 = dataTerima.substring(nC+1,nD);

    nPWM1 = sPWM1.toInt();
    nPWM2 = sPWM2.toInt();
    nPWM3 = sPWM3.toInt();

    analogWrite(3, nPWM1);
    analogWrite(5, nPWM2);
    analogWrite(6, nPWM3);
    }

}
