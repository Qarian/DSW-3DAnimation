using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWithFlipping : MonoBehaviour
{
    public float speed = 1f;

    private void Update()
    {
        // Używamy inputu od gracza w kilku miejscach
        // Możemy to zaakcentować tworząc lokalną zmienną która będzie trzymała rezultat funkcji
        // Dodatkowo kod jest szybszy (nie musimy wykonywać potencjalnie skomplikowanej operacji kilka razy)
        // I mamy pewność że wynik jest taki sam (czasami funkcja może zwrócić inny rezutat, albo zmienić coś innego przy okazji)
        float direction = Input.GetAxis("Horizontal");
        GetComponent<Transform>().Translate(direction * speed * Time.deltaTime, 0, 0);


        // Kod z zajęć - jest w nim błąd
        // Jeżeli gracz nie bedzie się ruszał to postać może zostać niepotrzebnie odwrócona
        /*if (direction < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }*/

        // Poprawnie powinniśmy obracać tylko jeżeli jest większe lub mniejsze niż 0
        // Dla 0 postać powinna zostać obrócona tak jak była wcześniej
        if (direction < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (direction > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
