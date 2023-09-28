using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class SerialCommunicator : MonoBehaviour
{
    private SerialPort _serialPort;
    private byte[] buffer;
    

    // Start is called before the first frame update
    void Start()
    {
        _serialPort = new SerialPort();
        _serialPort.PortName = "COM5";
        _serialPort.BaudRate = 9600;
        _serialPort.DtrEnable = true;
        _serialPort.NewLine = "\n";
        _serialPort.Open();
        Debug.Log("Open Serial Port");
        buffer = new byte[128];

    }


    // Método para enviar datos a Arduino desde otros scripts
    public void SendDataToArduino(string data)
    {
        if (_serialPort != null)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Write(data);
                Debug.Log("SerialPort.Write ejecutado");
            }
            else
            {
                Debug.LogWarning("El puerto serial no está abierto.");
            }
        }
        else
        {
            Debug.LogError("El objeto SerialPort no se ha inicializado correctamente.");
        }
    }



   

    // Update is called once per frame
    void Update()
    {
        
    }
}
