int ledPin = 13; // Pin del LED
int currentTemp;

void setup() {
  pinMode(ledPin, OUTPUT); // Configurar el pin del LED como salida
  Serial.begin(9600); // Iniciar comunicación serial a 9600 baudios
}

void loop() {
  if (Serial.available() > 0) {
    
    if(Serial.read() == '1'){
      digitalWrite(ledPin, HIGH); // Encender el LED en el pin 13
      
    }else if(Serial.read() == '2')
    {
      String dato = Serial.readString();
      currentTemp = dato.toInt(); 
    }

  }

  currentTemp=currentTemp-1;

if (currentTemp<=0){

currentTemp=0;
}
Serial.println(currentTemp);
delay(1000);
}
