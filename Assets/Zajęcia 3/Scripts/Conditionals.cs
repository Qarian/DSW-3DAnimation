using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    // publiczne zmienne do zmiany w inspektorze
    public bool simpleCondition = false; // domyślną wartością typu bool jest false
    public int integer1 = 0;
    public int integer2 = 0;

    public bool firstCondition; 
    public bool secondCondition = true;

    // Update is called once per frame
    void Update()
    {
        // Poniższy kod będzie co klatkę wyświetlał dużo wiadomości
        // Polecam zakomentować linijki które was nie interesują, lub nacisnąć opcję Collapse w oknie Console żeby takie same wiadomości się nie powtarzały

        /* Instrukcje warunkowe składają się z 3 elementów:
        1) Słowa kluczowego *if*
        2) Wyrażenie logiczne w nawiasach okrągłych () - może to być bezpośrednio wpisane true / false, zmienna bool lub cokolwiek inne co zwróci bool
        3) Instrukcja - pojedyńcza linijka kodu, lub kilka linijek w klamrach {}
        */

        // Przykład:
        if (simpleCondition)
        {
            Debug.Log("Prosty warunek jest spełniony");
        }

        // Do porównywania liczb (i nie tylko) można użyć: ==, !=, <, <=, >, >=
        if (integer1 == integer2)
            Debug.Log("Pierwsza liczba jest równa drugiej");
        if (integer1 != integer2)
            Debug.Log("Pierwsza liczba jest inna niż druga");
        if (integer1 < integer2)
            Debug.Log("Pierwsza liczba jest mniejsza od drugiej");
        if (integer1 <= integer2)
            Debug.Log("Pierwsza liczba jest mniejsza lub równa drugiej");
        if (integer1 > integer2)
            Debug.Log("Pierwsza liczba jest większa od drugiej");
        if (integer1 >= integer2)
            Debug.Log("Pierwsza liczba jest większa lub równa drugiej");

        // Instrukcje warunkowe można rozszerzyć o słowo kluczowe else, które działa gdy warunek nie będzie spełniony
        // Else musi być od razu po instrukcji przypisanej do if
        if (simpleCondition)
        {
            // po if musi być jakaś intrukcja by kod się kompilował
            // Pusta klamra tez jest traktowana jako instrukcja, mimo że nic nie robi
        }
        else
        {
            Debug.Log("Prosty warunek nie jest spełniony");
        }


        // Po else można napisać nową instrukcję warunkową
        // Pozwala to sprawdzić kilka wartości i skończyć na pierwszej która jest prawdą

        if (firstCondition)
            Debug.Log("Pierwszy warunek jest prawdą - koniec sprawdzania");
        else if (secondCondition)
            Debug.Log("Pierwszy warunek jest fałszem, ale drugi jest prawdą - koniec sprawdzania");
        else
            Debug.Log("Obydwa warunki są fałszem");

        // W powyższych przykładach pokazywałem raz z klamrami a raz bez, żeby pokazac że nie ma to znaczenia dla Unity
        // Jednak dla czytelności lepiej zdecydować się we własnym projekcie na używanie lub nie
    }
}
