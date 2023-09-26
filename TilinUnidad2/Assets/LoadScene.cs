using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private SerialCommunicator serialCommunicator;
    // Start is called before the first frame update
    void Start()
    {
        serialCommunicator.SendDataToArduino("0"); // Envía '1' a Arduino
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        
        SceneManager.LoadScene("Juego");
    }
}
