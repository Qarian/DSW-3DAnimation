using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Przesuwa obiekt 
public class Mover : MonoBehaviour
{
    // Domyślnie skrypt będzie przesuwał obiekt, do którego jest przypięty, o jedną jednostkę na sekundę w osi X (w prawo)
    public Vector3 speed = new Vector3(1, 0, 0);

    // Update is called once per frame
    private void Update()
    {
        // Time.deltaTime zwraca czas trwania klatki. Dzięki temu obiekt będzie przesuwał się z taką samą prędkością
        // nie ważne ile będzie klatek na sekundę (jak często wywoła się Update)
        GetComponent<Transform>().position += speed * Time.deltaTime;
        
        // += pozwala nam zapisać poniższą linijkę w prostszy sposób
        //GetComponent<Transform>().position = GetComponent<Transform>().position + (speed * Time.deltaTime);
    }
}
