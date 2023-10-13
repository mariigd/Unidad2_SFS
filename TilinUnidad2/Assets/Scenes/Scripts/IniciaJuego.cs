using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO.Ports;

public class IniciaJuego : MonoBehaviour
{
    private SerialPort _serialPort;
    private byte[] buffer;


    public TMP_InputField codigoInputField;
    public TextMeshProUGUI mensajeTexto;

    private string codigoCorrecto = "DDAADA"; 

    public TextMeshProUGUI NumAcertijo; 
    private int numeroActual;

    public TextMeshProUGUI ContadorTemp;

    int currentTemp = Config.temperature;


    private void Start()
    {


        _serialPort = new SerialPort();
        _serialPort.PortName = "COM5";
        _serialPort.BaudRate = 9600;
        _serialPort.DtrEnable = true;
        _serialPort.NewLine = "\n";
        _serialPort.Open();
        Debug.Log("Open Serial Port");
        buffer = new byte[128];

        Led();
        Contador();

        Debug.Log("Current Temp: " + currentTemp);
        GenerarYMostrarNumeroRandom();

    }

    private void Led()
    {
        _serialPort.Write("1"); // Envía '1' a Arduino
        Debug.Log("Enviar arduino");
    }

    private void OnApplicationQuit()
    {
        _serialPort.Write("0"); // Envía '0' a Arduino
    }

    private void Contador()
    {
        _serialPort.Write("2");
        Debug.Log("Enviar temp");
    }


    public void ValidarCodigo()
    {
        string codigoIngresado = codigoInputField.text;

        if (codigoIngresado == codigoCorrecto)
        {
            mensajeTexto.text = "Código correcto";

            StartCoroutine(CambiarEscenaG()); 
        }
        else
        {
            mensajeTexto.text = "Código incorrecto";
        }
    }

    // Asegurarse de cerrar el puerto serie cuando se detenga la aplicación o el objeto se destruya
    void OnDestroy()
    {
        if (_serialPort != null && _serialPort.IsOpen)
        {
            _serialPort.Close();
        }
    }


    private void Update()
    {
        // Mostrar temperatura
        if (_serialPort != null && _serialPort.IsOpen)
        {
            // Leer datos del puerto serial y actualizar currentTemp si se recibe un nuevo valor
            if (_serialPort.BytesToRead > 0)
            {
                string receivedData = _serialPort.ReadLine();
                if (int.TryParse(receivedData, out int newTemp))
                {
                    currentTemp = newTemp;
                }
            }
        }

        ContadorTemp.text = currentTemp.ToString();
        //if temperatura <=0
        if (currentTemp <= 0)
        {
            CambiarEscenaP();
        }
           
      if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
      {
        GenerarYMostrarNumeroRandom();
      }
    }

    private void GenerarYMostrarNumeroRandom()
    {
      // Genera un número aleatorio entre 1 y 30 (ambos inclusive)
       numeroActual = Random.Range(1, 31);

        // Muestra el número aleatorio en el campo de entrada de texto
        NumAcertijo.text = numeroActual.ToString();
    }

    private IEnumerator CambiarEscenaG()
    {
        // Espera durante 5 segundos
        yield return new WaitForSeconds(3f);

        // Cambia a otra escena (reemplaza "NombreDeLaEscena" con el nombre de la escena a la que deseas cambiar)
        SceneManager.LoadScene("Ganar");
    }

    private IEnumerator CambiarEscenaP()
    {
        yield return new WaitForSeconds(1f);
        // Cambia a otra escena (reemplaza "NombreDeLaEscena" con el nombre de la escena a la que deseas cambiar)
        SceneManager.LoadScene("Perder");

    }

}
