using UnityEngine;

public class TapKiller : MonoBehaviour
{
    public Spawner spawner;

    private void OnMouseDown()
    {
        spawner.CreateNew();
        Destroy(gameObject);
    }
}
