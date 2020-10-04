int low = 0;
int medium = 0;
int high = 0;
const int recieveHighPin = A0;
const int recieveMediumPin = A1;
const int recieveLowPin = A2;
LiquidCrystal_I2C lcd(0x3F,20,4); 

void setup()
{
  lcd.init();                   
  lcd.init();
  // Print a message to the LCD.
  lcd.backlight();
  lcd.clear();
  lcd.setCursor(0,0);
   lcd.setCursor(2,1);
  lcd.print("By: HA, MR, CT");
delay(3000);
}

void loop(){
  high = analogRead(recieveHighPin);
  medium = analogRead(recieveMediumPin);
  low = analogRead(recieveLowPin);

  if(high < 1000){
    if(medium < 1000){
      if(low < 1000){
       } else{
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("Low water!");
          lcd.setCursor(0,1);
          lcd.print("FLOOD - LOG"); 
       }  
       } else {
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("Water level:");
          lcd.setCursor(0,1);
          lcd.print("Standard");
       
    }
  } else {
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("Water level:");
          lcd.setCursor(0,1);
          lcd.print("WARNING");
  }

}
