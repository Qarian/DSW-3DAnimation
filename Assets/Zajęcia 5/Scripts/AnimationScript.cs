using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public float speed;

    public Animator animator;
    
    // Zmienne które mają za typ komponent trzymają referencję do komponentu
    // Jezeli są publiczne to da się je ustawić w edytorze
    public SpriteRenderer spriteRenderer;
    Transform transformOther;
    
    void Start()
    {
        transformOther = spriteRenderer.GetComponent<Transform>();
    }
    
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transformOther.Translate(direction * speed * Time.deltaTime, 0, 0);

        if (direction < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (direction > 0)
        {
            spriteRenderer.flipX = false;
        }

        direction = Mathf.Abs(direction);

        // Ustawianie wartości w animatorze
        // Nazwa zmienne musi być dokładnie taka sama - najlepiej przekopiować
        animator.SetFloat("Speed", direction);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }
    }
}
