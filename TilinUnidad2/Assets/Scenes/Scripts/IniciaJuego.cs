using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class IniciaJuego : MonoBehaviour
{
    private SerialCommunicator serialCommunicator;

    public TMP_InputField codigoInputField;
    public TextMeshProUGUI mensajeTexto;

    private string codigoCorrecto = "DDAADA"; 

    public TextMeshProUGUI NumAcertijo; 
    private int numeroActual;


    private void Start()
    {
        serialCommunicator.SendDataToArduino("1"); // Envía '1' a Arduino
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

    //private IEnumerator CambiarEscenaP()
    //{
    //    // Cambia a otra escena (reemplaza "NombreDeLaEscena" con el nombre de la escena a la que deseas cambiar)
    //    SceneManager.LoadScene("Perder");
    //}

}
