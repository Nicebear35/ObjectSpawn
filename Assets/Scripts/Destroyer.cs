using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private const string Enemy = "Enemy";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Enemy))
        {  
            Destroy(collision.gameObject);
        }
    }
}
