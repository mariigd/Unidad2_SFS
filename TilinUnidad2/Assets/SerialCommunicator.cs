using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class SerialCommunicator : MonoBehaviour
{
    private SerialPort _serialPort;

    // Start is called before the first frame update
    void Start()
    {
        _serialPort = new SerialPort();
        _serialPort.PortName = "COM5"; // Ajusta el nombre del puerto COM según corresponda
        _serialPort.BaudRate = 9600;
        _serialPort.DtrEnable = true;
        _serialPort.NewLine = "\n";
        _serialPort.Open();
        Debug.Log("Open Serial Port");

    }


    // Método para enviar datos a Arduino desde otros scripts
    public void SendDataToArduino(string data)
    {
        if (_serialPort != null && _serialPort.IsOpen)
        {
            _serialPort.Write(data);
        }
    }



   

    // Update is called once per frame
    void Update()
    {
        
    }
}
