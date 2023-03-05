using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private Fruit _fruit;
    private Player _player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Fruit>())
        {  
            Destroy(collision.gameObject);
        }
    }
}
