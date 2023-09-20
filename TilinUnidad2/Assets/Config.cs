using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;
using TMPro;


enum TaskState
{
    INIT,
    WAIT_COMMANDS
}

public class Config : MonoBehaviour
{
    private static TaskState taskState = TaskState.INIT;
    private SerialPort _serialPort;
    private byte[] buffer;

    //Botones
    public Button TempMas;
    public Button TempMenos;

    public Button ALTmas;
    public Button ALTmenos;

    public Button PresMas;
    public Button PresMenos;

    public Button Comenzar;

    //Boton presionado
    private bool PresionadoTempMas = false;
    private bool PresionadoTempMenos = false;

    private bool PresionadoALTmas = false;
    private bool PresionadoALTmenos = false;

    private bool PresionadoPresMas = false;
    private bool PresionadoPresMenos = false;

    private bool PresionadoComenzar = false;

    //Variables
    int temperature = 0;
    
    int altura = 0;
    int presion = 0;

    



    // Start is called before the first frame update
    void Start()
    {
        _serialPort = new SerialPort();
        _serialPort.PortName = "COM3";
        _serialPort.BaudRate = 9600;
        _serialPort.DtrEnable = true;
        _serialPort.NewLine = "\n";
        _serialPort.Open();
        Debug.Log("Open Serial Port");
        buffer = new byte[128];

        TempMas = GetComponent<Button>();
        TempMenos = GetComponent<Button>();
        ALTmas = GetComponent<Button>();
        ALTmenos = GetComponent<Button>();
        PresMas = GetComponent<Button>();
        PresMenos = GetComponent<Button>();
        Comenzar = GetComponent<Button>();

        TempMas.onClick.AddListener(ModificarTemp);
        TempMenos.onClick.AddListener(ModificarTemp);
        ALTmas.onClick.AddListener(ModificarAlt);
        ALTmenos.onClick.AddListener(ModificarAlt);
        PresMas.onClick.AddListener(ModificarPresion);
        PresMenos.onClick.AddListener(ModificarPresion);
        

    }

    private void ModificarTemp()
    {
        PresionadoTempMas = !PresionadoTempMas;
        if(PresionadoTempMas == true)
        {
            temperature++;
        }
        PresionadoTempMenos = !PresionadoTempMenos;
        if(PresionadoTempMenos == true)
        {
            temperature--;
            if (temperature < 0)
            {
                temperature = 0;
            }
        }

        int acertijos = temperature;
    }

    private void ModificarAlt()
    {
        PresionadoALTmas = !PresionadoALTmas;
        if (PresionadoALTmas  == true)
        {
            altura++;
        }
        PresionadoALTmenos =!PresionadoALTmenos;
        if (PresionadoALTmenos == true)
        {
            altura--;
            if (altura < 0)
            {
                altura = 0;
            }
        }
    }

    private void ModificarPresion()
    {
        PresionadoPresMas = !PresionadoPresMas;
        if (PresionadoPresMas == true)
        {
            presion++;
        }
        PresionadoPresMenos = !PresionadoPresMenos;
        if (PresionadoPresMenos == true)
        {
            presion--;
            if (presion < 0)
            {
                presion = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
