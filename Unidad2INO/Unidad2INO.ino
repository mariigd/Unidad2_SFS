int currentTemp = 20; // Inicializar la temperatura en 20
constexpr uint8_t led = 25;

void setup() {
  pinMode(led, OUTPUT); // Configurar el pin del LED como salida
  digitalWrite(led, LOW);
  Serial.begin(9600); // Iniciar comunicación serial a 9600 baudios
}

void loop() {
  if (Serial.available() > 0) {
    char receivedChar = Serial.read(); // Leer el valor del puerto serial y almacenarlo
    
    if (receivedChar == '1') {
      digitalWrite(led, HIGH); // Encender el LED en el pin 13
    } else if (receivedChar == '0') {
      digitalWrite(led, LOW);
    } else if (receivedChar == '2') {
      while (currentTemp > 0) {
        currentTemp = currentTemp - 1;
        Serial.println(currentTemp);
        delay(1000);
      }
      
    }
  }
  // Envía el valor actualizado de currentTemp continuamente
  Serial.println(currentTemp);
  delay(1000); // Puedes ajustar este valor según tus necesidades
}
