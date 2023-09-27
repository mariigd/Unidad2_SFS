using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;
using TMPro;



public class Config : MonoBehaviour
{

    private SerialCommunicator serialCommunicator;


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
    public static int temperature = 20;
    int acertijos =  temperature;
    int altura = 0;
    int presion = 0;

    //Visualización de temperatura
    public Image TempIMG;
    public Sprite Frio;
    public Sprite Congelado;
    public Sprite Caliente;
    public Sprite Asado;
    public Sprite Normal;

    //Visualización de Altura
    public Image AltIMG;
    public Sprite Media;
    public Sprite Alta;
    public Sprite Baja;

    //Visualización de Presion
    public Image PresIMG;
    public Sprite PresB;
    public Sprite PresM;
    public Sprite PresA;

    public TextMeshProUGUI NumAcertijos;
    


    // Start is called before the first frame update
    void Start()
    {
        GameObject controladorOBJ = GameObject.Find("SerialCom");

        if(controladorOBJ != null)
        {
            serialCommunicator = controladorOBJ.GetComponent<SerialCommunicator>();
        }
        else
        {
            Debug.LogError("No se encontró");
        }

        Led();
    }

    private void Led()
    {
        serialCommunicator.SendDataToArduino("1"); // Envía '2' a Arduino
        Debug.Log("Enviar arduino");
    }

    public void MasTemp()
    {

        PresionadoTempMas = !PresionadoTempMas;
        if(PresionadoTempMas == true)
        {
            temperature++;
            if (temperature > 30)
            {
                temperature = 30;
            }
        }

        Debug.Log("Botón TempMas clicado");
        Debug.Log("Valor de temperature: " + temperature);
        NumAcertijos.text = temperature.ToString();
        Debug.Log("Valor de acertijos: " + acertijos);
    }
    public void MenosTemp()
    {
        PresionadoTempMenos = !PresionadoTempMenos;
        if (PresionadoTempMenos == true)
        {
            temperature--;
            if (temperature < 10)
            {
                temperature = 10;
            }
        }
        Debug.Log("Botón TempMenos clicado");
        Debug.Log("Valor de temperature: " + temperature);
        NumAcertijos.text = temperature.ToString();
    }

    public void MasAlt()
    {
        PresionadoALTmas = !PresionadoALTmas;
        if (PresionadoALTmas  == true)
        {
            altura++;
        }

        Debug.Log("Botón MasALT clicado");
        Debug.Log("Valor de altura: " + altura);
    }

    public void MenosAlt()
    {
        PresionadoALTmenos = !PresionadoALTmenos;
        if (PresionadoALTmenos == true)
        {
            altura--;
            if (altura < 0)
            {
                altura = 0;
            }
        }
        Debug.Log("Botón MenosALT clicado");
        Debug.Log("Valor de altura: " + altura);
    }

    public void MasPresion()
    {
        PresionadoPresMas = !PresionadoPresMas;
        if (PresionadoPresMas == true)
        {
            presion++;
        }

        Debug.Log("Botón MasPresion clicado");
        Debug.Log("Valor de presion: " + presion);

    }

    public void MenosPresion()
    {
        
        PresionadoPresMenos = !PresionadoPresMenos;
        if (PresionadoPresMenos == true)
        {
            presion--;
            if (presion < 0)
            {
                presion = 0;
            }
        }
        Debug.Log("Botón MenosPresion clicado");
        Debug.Log("Valor de presion: " + presion);
    }




    // Update is called once per frame
    void Update()
    {
        //Temperatura
        if (temperature == 10)
        {
            TempIMG.sprite = Congelado;
        }
        if (temperature == 15)
        {
            TempIMG.sprite = Frio;
        }
        else if(temperature == 20)
        {
            TempIMG.sprite = Normal;
        }

        if (temperature == 25)
        {
            TempIMG.sprite = Caliente;
        }
        if (temperature == 30)
        {
            TempIMG.sprite = Asado;
        }

        //Altura
        if (altura == 5)
        {
            AltIMG.sprite = Media;
        }
        if (altura == 10)
        {
            AltIMG.sprite = Alta;
        }
        if (altura == 0)
        {
            AltIMG.sprite = Baja;
        }

        //Presion
        if (presion == 5)
        {
            PresIMG.sprite = PresM;
        }
        if (presion == 10)
        {
            PresIMG.sprite = PresA;
        }
        if (presion == 0)
        {
            PresIMG.sprite = PresB;
        }


    }
}
