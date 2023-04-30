using UnityEngine;

public class Targeting : MonoBehaviour
{
    public float speed = 3;

    public Transform target;

    void Update()
    {
        Vector2 ownPosition = transform.position;
        Vector2 targetPosition = target.position;
        // Wektor który odpowiada odległości między dwiema pozycjami
        Vector2 distance = targetPosition - ownPosition;
        
        // Ustawianie się w kierunku celu, zakładając grę 2D
        transform.up = distance.normalized;
        
        // Floaty nie są dokładne więc trzeba sprawdzać z marginesem błędu
        if (distance.magnitude > 0.1f)
        {
            transform.Translate(distance.normalized * Time.deltaTime * speed, Space.World);
        }
    }
}
