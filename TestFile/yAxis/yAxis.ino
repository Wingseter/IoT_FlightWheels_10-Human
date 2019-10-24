const int analogPin = A1;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
}

void loop() {
  // put your main code here, to run repeatedly:

  // mapping the y value in to 0~1023;
  int mapping;

  mapping = (analogRead(A1) - 490) * 14;
  if(mapping < 0){
    mapping = 0;
  }
  else if(mapping > 1023){
    mapping = 1023;
  }
  Serial.println(mapping);
}
