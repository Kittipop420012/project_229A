using UnityEngine;

public class TorchDestroyer : MonoBehaviour
{
    public string ownerTag = "Player2"; // เจ้าของคบเพลิงคือ Player2

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Player1"))
        {
            ScoreManagerP2.Instance.AddScore(1);
            Destroy(gameObject);
        }

}
}