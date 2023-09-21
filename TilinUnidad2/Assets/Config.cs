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

    //Visualización de las variables
    public Image TempIMG;
    public Sprite Frio;
    public Sprite Caliente;





    // Start is called before the first frame update
    void Start()
    {
        
        //Manejo de botones
        

        TempMas.onClick.AddListener(ModificarTemp);
        TempMenos.onClick.AddListener(ModificarTemp);
        ALTmas.onClick.AddListener(ModificarAlt);
        ALTmenos.onClick.AddListener(ModificarAlt);
        PresMas.onClick.AddListener(ModificarPresion);
        PresMenos.onClick.AddListener(ModificarPresion);

        

    }

    public void ModificarTemp()
    {

        PresionadoTempMas = !PresionadoTempMas;
        if(PresionadoTempMas == true)
        {
            temperature += 5;
        }

        PresionadoTempMenos = !PresionadoTempMenos;
        if(PresionadoTempMenos == true)
        {
            temperature -= 5;
            if (temperature < 0)
            {
                temperature = 0;
            }
        }

        if (temperature == 10)
        {
            TempIMG.sprite = Frio;
        }
        else if (temperature == 30)
        {
            TempIMG.sprite = Caliente;
        }
        Debug.Log("Botón TempMas o TempMenos clicado");
        Debug.Log("Valor de temperature: " + temperature);
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
