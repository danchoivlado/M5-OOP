#include <SoftwareSerial.h>
#include <LiquidCrystal_PCF8574.h>
#include <Wire.h>
#include <Servo.h>
#include <Servo.h>
Servo ServoLock;
const int LedGreen = 8;
const int LedRed = 7;
const int LedYellow = 6;
const int Zoomer = 12;
const int buttonPin = 3;
bool buttonState ;  
SoftwareSerial RF(10, 11); // RX, TX
int cardNumber;
bool wasInWhile = false;
String brak;
String SerialCommand;

LiquidCrystal_PCF8574 lcd(0x27); // set the LCD address to 0x27 for a 16 chars and 2 line display


void setup() {
  Serial.begin(9600);
  RF.begin(9600);
  ServoLock.attach(4); 
  digitalWrite(Zoomer,LOW);
  pinMode(buttonPin, INPUT_PULLUP);

  InitializeLEDs();
  InitializeLCD();
}

void loop() {

  //Waits for input from the program
  if(Serial.available()){
    //Reads the input from the program
    SerialCommand = Serial.readString(); 
    //if prograServoLock is now started
    if(SerialCommand=="EmergencyAlarmOn"){
      //Displays on LCD "Emergency Open"
      LCDEmergencyOpen();
      ServoOpen();
      //Power onn both LED
      EmergencyLEDOn();
    }
       //When you cencel the Emergency 
    if(SerialCommand=="EmergencyAlarmOff"){
      ServoClose();
      LcdClearWithoutDelay();
      EmergencyLEDOff();
    }
    
    if(SerialCommand=="CommunicationON"){
      //Turns on Communication LED
      digitalWrite(LedYellow,HIGH);
    }
    //if program is closing
    if(SerialCommand=="CommunicationOFF"){
      //Turns off Communication LED
      digitalWrite(LedYellow,LOW);
    }
  }

  
  //Reads the cardNumber from the RF Reader  
 while(RF.available()>0){
  cardNumber =RF.read();
  //Sends the readed cardNumber from the card to Serial Port
  Serial.println(cardNumber);
  wasInWhile = true;
 }
  
 if(wasInWhile){
      wasInWhile = false;
      //Reads the input from the program
      brak = Serial.readString(); 
      //Checks for false Scanned text
      if(brak!="0"&&brak!="ScanedCardForRegistration"&&brak !="CommunicationON"&&brak!="CommunicationOFF"&&brak!=""){
        LEDPassLCD(brak);
        Pass();
      }
      if(brak=="0"){
        NotPass();
      } 
 }
 //Checks for pressed "Manual Opne" button
 CheckBUT();
}

void Pass(){
  digitalWrite(Zoomer,HIGH);
  ServoOpen();
  LEDPass();
  digitalWrite(Zoomer,LOW);
  LcdClear();
  ServoClose();
}
void NotPass(){
  LCDNotPass();
  LEDNotPass();
  LcdClear();
}
void InitializeLCD(){
  Wire.begin();
  Wire.beginTransmission(0x27);
  lcd.begin(20, 4); // initialize the lcd
  lcd.setBacklight(255);
  lcd.clear();   
  lcd.setCursor(0, 0);
  lcd.print("Scanning...");
}

void InitializeLEDs(){
   pinMode(LedGreen,OUTPUT);
  pinMode(LedYellow,OUTPUT);
  pinMode(LedRed,OUTPUT);
  digitalWrite(LedYellow,LOW);
}

void LEDPass(){  
      digitalWrite(LedGreen,HIGH);
      delay(2200);
      digitalWrite(LedGreen,LOW);    
      
}
void EmergencyLEDOn(){
   digitalWrite(LedGreen,HIGH);
   digitalWrite(LedRed,HIGH);
}

void EmergencyLEDOff(){
   digitalWrite(LedGreen,LOW);
   digitalWrite(LedRed,LOW);
}
void ServoOpen(){
  ServoLock.write(50);
  delay(653);
  ServoLock.write(90);
}

void ServoClose(){
  ServoLock.write(150);
  delay(653);
ServoLock.write(90);
}

void CheckBUT(){
  //If button is pressed
  if(digitalRead(buttonPin)==LOW){
    //If button was pressed before
 if (buttonState == LOW) {
  digitalWrite(LedGreen,HIGH);
 // digitalWrite(Zoomer,HIGH);
    LCDOpenedByManual();
    ServoOpen();
    
  } 
  else {
    // turn LED off:
    digitalWrite(LedGreen,LOW);
 //   digitalWrite(Zoomer,LOW);
    LcdClearWithoutDelay();
    ServoClose();
     
  }
  //Change the button state to opasite
  buttonState=!buttonState;
  delay(200);
}
}
void LEDNotPass(){
  for(int a=0;a<2;a++)
  { 
        digitalWrite(LedRed,HIGH);
        
        digitalWrite(Zoomer,HIGH);
        delay(1000);
        digitalWrite(Zoomer,LOW);
        
        digitalWrite(LedRed,LOW);

       
        delay(1000);
        digitalWrite(Zoomer,LOW);
  }
}

void LCDOpenedByManual(){
  lcd.clear();
  lcd.setCursor(0, 0);
   lcd.print("Wait To Pass");
   lcd.setCursor(0, 1);
   lcd.print("Opened By Manual");  
}

void LCDEmergencyOpen(){
  lcd.clear();
  lcd.setCursor(0, 0);
   lcd.print("Wait To Pass");
   lcd.setCursor(0, 1);
   lcd.print("Emergency Open");
    lcd.setCursor(0, 2);
   lcd.print("====>>>"); 
   lcd.setCursor(0, 3); 
    lcd.print("20m"); 
}

void LEDPassLCD(String EmpName){
  lcd.clear();
  lcd.setCursor(0, 0);
   lcd.print("Wait To Pass");
   lcd.setCursor(0, 1);
   lcd.print("Hello");
   lcd.setCursor(0, 2);
   //Prints the name of scanned Eployee
   lcd.print(EmpName);
   lcd.setCursor(5, 3);
   lcd.print("Welcome");
   
}
void LCDNotPass(){
  lcd.clear();
  lcd.setCursor(0, 0);
   lcd.print("Wait To Pass");
   lcd.setCursor(0, 1);
   lcd.print("Acces Denied");
   lcd.setCursor(0, 2);
   lcd.print(":(:(:(:(:(:(:(:(:(");
}

void LcdClearWithoutDelay(){
  lcd.clear();
  lcd.clear();
  lcd.setCursor(0, 0);
   lcd.print("Scanning...");
}
void LcdClear(){
  delay(3000);
  lcd.clear();
  lcd.clear();
  lcd.setCursor(0, 0);
   lcd.print("Scanning...");
}
