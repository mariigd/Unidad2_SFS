using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;
using TMPro;



public class Config : MonoBehaviour
{


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
    public int temperature = 20;
    
    int altura = 0;
    int presion = 0;

    //Visualizaci�n de las variables
    public Image TempIMG;
    public Sprite Frio;
    public Sprite Congelado;
    public Sprite Caliente;
    public Sprite Asado;
    public Sprite Normal;





    // Start is called before the first frame update
    void Start()
    {
        
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

        Debug.Log("Bot�n TempMas o TempMenos clicado");
        Debug.Log("Valor de temperature: " + temperature);
        int acertijos = temperature;
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
        Debug.Log("Bot�n TempMas o TempMenos clicado");
        Debug.Log("Valor de temperature: " + temperature);
    }

    public void MasAlt()
    {
        PresionadoALTmas = !PresionadoALTmas;
        if (PresionadoALTmas  == true)
        {
            altura++;
        }
        
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
    }

    public void MasPresion()
    {
        PresionadoPresMas = !PresionadoPresMas;
        if (PresionadoPresMas == true)
        {
            presion++;
        }
       
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
    }




    // Update is called once per frame
    void Update()
    {
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

    }
}
