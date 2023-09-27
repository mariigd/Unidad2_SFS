using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO.Ports;

public class IniciaJuego : MonoBehaviour
{
    private SerialCommunicator serialCommunicator;

    public TMP_InputField codigoInputField;
    public TextMeshProUGUI mensajeTexto;

    private string codigoCorrecto = "DDAADA"; 

    public TextMeshProUGUI NumAcertijo; 
    private int numeroActual;

    public TextMeshProUGUI ContadorTemp;

    int currentTemp = Config.temperature;


    private void Start()
    {
        serialCommunicator.SendDataToArduino("2"); // Envía '2' a Arduino
        Debug.Log("Current Temp: " + currentTemp);
        GenerarYMostrarNumeroRandom();

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



    private void Update()
    {
        //Mostrar temperatura
        ContadorTemp.text = currentTemp.ToString();
        //if temperatura <=0
        if(currentTemp <= 0)
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
