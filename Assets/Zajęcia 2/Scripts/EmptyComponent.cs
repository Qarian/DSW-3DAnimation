using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using są na górze pliku i dają dostęp do zaawansowanych typów - w przyszłości będziemy dodawać inne

// public jest modyfikatorem dostępu - mówi że to co jest po nim może być używane przez inne klasy.
//        Innym modyfikatorem jest private, który na to nie pozwala. Jak nie ma podanego modyfikatora to domyślnie jest private
// class jest słowem kluczowym które dajemy przed nazwą klasy
// EmptyComponent to nazwa tej klasy, musi to być dokładnie ta sama nazwa co nawa pliku, inaczej Unity nie pozwoli dodać tego skryptu jako komponentu
// MonoBehaviour po dwukropku sprawia że nasza klasa może być używana jako komponent, mamy dostep do Start, Update i innych
public class EmptyComponent : MonoBehaviour
{
    // Komentarze można robić na 2 sposoby:
    // 2 ukośniki komentują wszystko co jest na prawo od nich 
    
    /* Ukośnik z gwiazdą zaczynają komentarz na więcej niż 1 linię.
     Koniec komentarza oznacza się gwiazdą i ukośnikiem (odwrotna kolejność)*/
    
    // W C# znaki białe (spacja, tabulacja, koniec lini) służą do odzielenia słów od siebie, nie ma znaczenia ile ich jest pomiędzy
}