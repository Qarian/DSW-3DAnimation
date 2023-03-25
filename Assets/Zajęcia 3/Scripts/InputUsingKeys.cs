using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputUsingKeys : MonoBehaviour
{
    void Update()
    {
        // Klasa Input jak sama nazwa mówi jest odpowiedzalne za wykrywanie co nacisnął gracz
        // Do bezpośredniego sprawdzenia co nacisnął gracz można użyć funkcji GetKey i GetButton

        // GetKey(), GetKeyDown() i GetKeyUp() przyjmują jako parametr enuma odpiadającego przyciskowi i zwracają wartość typu bool:
        // GetKeyDown() zwraca true jeżeli dopiero w tej klatce przycisk został wciśnięty, false w przyciwnym wypadku
        // GetKey() zwraca true jeżeli przycisk jest trzymany w tej klatce, false w przeciwnym wypadku
        // GetKeyUp() zwraca true jeżeli przycisk został puszczony w tej klatce, false w przyciwnym wypadku

        // Enumy mają 2 duże plusy:
        // 1) Visual Studio jest w stanie wykryć jakie są opcje (wyświetla się lista po wciśnięciu kropki)
        // 2) Jeżeli podamy niepoprawną wartość bedzie ona podkreslona na czerwono i w oknie konsol będzie błąd wskazujący na konkretną linijkę 

        if (Input.GetKeyDown(KeyCode.E))
            Debug.Log("Właśnie został wciśnięty przycisk E");
        if (Input.GetKey(KeyCode.E))
            Debug.Log("Przycisk E jest trzymany");
        if (Input.GetKeyUp(KeyCode.E))
            Debug.Log("Przycisk E został puszczony");

        // GetButton(), GetButtonDown() i GetButtonUp() działają analogicznie do GetKey ale przyjmują jako argument string (tekst)

        if (Input.GetButtonDown("E"))
            Debug.Log("E powinno być duże?");
        if (Input.GetButtonDown("e"))
            Debug.Log("Czy może e powinno być małe?");
        // VS nam tutaj nie podpowiada
    }
}
