using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputUsingAxis : MonoBehaviour
{
    void Update()
    {
        // Klasa Input daje nam możliwość zczytania inputu gracza nie przejmując się jaki to konkretnie przycisk został wciśnięty
        // Używa się do tego funckji GetAxis() - przyjmuje ona stringa z nazwą osi i zwraca wartość typu float w zakresie od -1 do 1
        // -1 to maksymalna wartość negatywna, 1 mkszymalna pozytywna, jak nie ma inputu od gracza to jest 0
        // Osie są konfigurowane w Unity pod Projekt Settings -> Input Manager

        // Dodatkowo GetAxis() pozwala symulować poruszanie drążkiem nawet gdy używamy klawiatury - o nie staje się 1 od razu ale płynnie przechodzi
        // Zwykle jest to oczekiwany rezultat, ale jeżeli tego nie chcemy to można użyć GetAxisRaw()

        // Nazwa osi musi być dokładnie taka sama jak w Unity bo inaczej po prostu nie zadziała - polecam przekopiować a nie przepisać
        float horizontalMovement = Input.GetAxis("Horizontal");
        Debug.Log("Wartość inputu w osi poziomej: " + horizontalMovement);
    }
}
