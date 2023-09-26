int ledPin = 13; // Pin del LED

void setup() {
  pinMode(ledPin, OUTPUT); // Configurar el pin del LED como salida
  Serial.begin(9600); // Iniciar comunicación serial a 9600 baudios
}

void loop() {
  if (Serial.available() > 0) {
    char incomingData = Serial.read(); // Leer datos entrantes

    if (incomingData == '1') {
      digitalWrite(ledPin, HIGH); // Encender el LED en el pin 13
    } else if (incomingData == '0') {
      digitalWrite(ledPin, LOW); // Apagar el LED en el pin 13
    }
  }
}
