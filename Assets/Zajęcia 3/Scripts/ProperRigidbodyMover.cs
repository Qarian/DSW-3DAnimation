using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProperRigidbodyMover : MonoBehaviour
{
    public float speed = 2f;
    // Rzeczy związane z fizyką nie robimy co klatkę a co tak zwaną "klatkę fizyczną"
    // Odstępy między takimi klatkami są stałe i wynoszą Time.fixedDeltaTime
    // Wartość można zmienić w Unity pod ProjectSettings -> Time -> Fixed Timestep
    // Jak Update i FixedUpdate odnoszą się do siebie można sprawdzić pod https://docs.unity3d.com/Manual/ExecutionOrder.html
    private void FixedUpdate()
    {
        // Obiekt do którego jest przyczepiony ten skrypt musi mieć w sobie komponent Rigidbody bo inaczej będzie się wyswietlał błąd

        //MovePosition jako argument przyjmuje Vector3 ale nie taki co mówi o ile trzeba się przesunąć, ale taki co mówi na ją pozycję
        GetComponent<Rigidbody>().MovePosition(
            GetComponent<Transform>().position + //aktualna pozycja
            (Vector3.right * Input.GetAxis("Horizontal") + Vector3.forward * Input.GetAxis("Vertical")) // kierunek przesunięcia
            * speed * Time.fixedDeltaTime); // wartośc przesunięcia (jak bardzo)

        // Time.fixedDeltaTime jest tutaj opcjonalne bo klatka zawsze bedzie trwała tyle samo
        // Polecam jednak dodawać by wyglądało podobnie do normalnego poruszania + jak zmienicie Fixed Timestep to dalej będzie się poruszał z taką samą prędkością
    }
}
