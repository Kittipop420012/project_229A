using UnityEngine;

public class ThrowingController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform throwPoint;
    public float arcHeight = 2f;

    public void ThrowProjectileAtTarget(Transform target)
    {
        GameObject projectile = Instantiate(projectilePrefab, throwPoint.position, Quaternion.identity);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.gravityScale = 1f;

        Vector2 start = throwPoint.position;
        Vector2 end = target.position;

        Vector2 velocity = CalculateArcVelocity(start, end, arcHeight);
        rb.velocity = velocity;
    }

    // ฟิสิกส์การขว้างแบบโค้ง
    private Vector2 CalculateArcVelocity(Vector2 start, Vector2 end, float height)
    {
        float gravity = Mathf.Abs(Physics2D.gravity.y);
        float displacementY = end.y - start.y;
        Vector2 displacementX = new Vector2(end.x - start.x, 0);

        float timeUp = Mathf.Sqrt(2 * height / gravity);
        float timeDown = Mathf.Sqrt(2 * (height - displacementY) / gravity);
        float totalTime = timeUp + timeDown;

        Vector2 velocityY = Vector2.up * Mathf.Sqrt(2 * gravity * height);
        Vector2 velocityX = displacementX / totalTime;

        return velocityX + velocityY;
    }
}
