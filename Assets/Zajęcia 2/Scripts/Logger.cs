using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ta klasa wyświetla w konsoli co klatkę zawartośc w zmiennej
public class Logger : MonoBehaviour
{
    // Zmienna jest publiczna więc można ją edytować  w inspektorze
    public string message = "Domyslna wartość";
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log(message);
    }
}
