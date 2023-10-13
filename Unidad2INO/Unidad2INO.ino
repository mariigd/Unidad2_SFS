int currentTemp; // Inicializar la temperatura
constexpr uint8_t led = 25;
int currentVel = 4;

void setup() {
  pinMode(led, OUTPUT); // Configurar el pin del LED como salida
  digitalWrite(led, LOW);
  Serial.begin(9600); // Iniciar comunicación serial a 9600 baudios
  currentTemp = 20; // Establecer la temperatura inicial en 20
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
        delay(currentVel * 1000);
      }
    }
  }
}
