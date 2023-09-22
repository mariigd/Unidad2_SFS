using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;
using TMPro;


public class Temperature : MonoBehaviour
{
    public int temperature = 20;
    

    private void Start()
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

