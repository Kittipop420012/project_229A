using UnityEngine;

public class RockDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Ground"))
    {
        Destroy(gameObject); // หินหายเมื่อชน Player หรือ พื้น
    }
}
}
