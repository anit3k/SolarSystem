//AnalogPINs for Force Sensors
int sensorPin0  = A0;      // input pin for Sun
int sensorPin1  = A1;      // input pin for Mercury
int sensorPin2  = A2;      // input pin for Venus
int sensorPin3  = A3;      // input pin for Earth
int sensorPin4  = A4;      // input pin for Moon
int sensorPin5  = A5;      // input pin for Mars
int sensorPin6  = A6;      // input pin for Jupiter
int sensorPin7  = A7;      // input pin for Saturn
int sensorPin8  = A8;      // input pin for Uranus
int sensorPin9  = A9;      // input pin for Neptune
int sensorPin10 = A10;     // input pin for Pluto

//Array for AnalogPINs
byte analog_pins[] = {sensorPin0,sensorPin1,sensorPin2,sensorPin3,sensorPin4,sensorPin5,sensorPin6,sensorPin7,sensorPin8, sensorPin9};
//Variales for store values of the Force Sensors
int sensorValue = 0;
// select the pin for the LED
int ledPin = 13;
// activation limit      
int sensorLimit = 300;

void setup() {
  // declare the ledPin as an OUTPUT:
  Serial.begin(9600);
  pinMode(ledPin, OUTPUT);
}

void loop() {
  for (int i = 0; i < 10; i++) {
    sensorValue = analogRead(analog_pins[i]);
    //Serial.println(sensorValue);
    if(sensorValue>sensorLimit){
     digitalWrite(ledPin, HIGH);
     sendAPI(i, sensorValue);
    }else{
      digitalWrite(ledPin, LOW);
    }
  }
  
}

void sendAPI(int sensorNum, int pressure){
  Serial.println(sensorNum);
  delay(500);
}