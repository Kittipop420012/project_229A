using UnityEngine;

public class RockDestroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player2"))
        {
            ScoreManagerP1.Instance.AddScore(1);  // เพิ่มคะแนน
            Destroy(gameObject); // หินหาย
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject); // หินตกพื้นหาย
        }
    }
}
