int trig = 0;
bool detected = false;
String Control;
int val;
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
pinMode(4,INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
if(Serial.available() > 0)
{
  Control = Serial.readString();
}
if(Control == "On")
{
 val = digitalRead(4);
if (!detected&&val == 0)
{
  detected = true;
  trig++;
}
else if(detected && val == 1)
{
  detected = false;
}
else;
if(trig%2==1)
{
   Serial.write('n');
}
else
{
   Serial.write('f');
}
Serial.write('\n');
delay(75);
}
else if(Control == "Off")
{
  val = 0;
  trig = 0;
}
}
