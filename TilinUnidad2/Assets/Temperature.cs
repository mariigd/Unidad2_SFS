using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;
using TMPro;

public class Temperature : MonoBehaviour
{

    
    public int temperature = 20;

    

    // Start is called before the first frame update
    void Start()
    {

        

    }

    

    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void MasTemp()
    {


        temperature += 5;


        Debug.Log("Botón TempMas clicado");
        Debug.Log("Valor de temperature: " + temperature);
        int acertijos = temperature;
    }

    public void MenosTemp()
    {
        temperature -= 5;
        if (temperature < 0)
        {
            temperature = 0;
        }
    }
}
