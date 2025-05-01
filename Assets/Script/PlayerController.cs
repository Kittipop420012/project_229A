using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject projectilePrefab;
    public Transform throwPoint;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;
    public KeyCode throwKey = KeyCode.W;
    public Vector2 throwDirection = new Vector2(1, 1); // ปาขวาขึ้น

    void Update()
    {
        // การเคลื่อนที่ซ้าย-ขวา
        float moveX = 0f;

        if (Input.GetKey(leftKey)) moveX = -1f;
        if (Input.GetKey(rightKey)) moveX = 1f;

        Vector3 movement = new Vector3(moveX, 0f, 0f).normalized;
        transform.position += movement * moveSpeed * Time.deltaTime;

        // ปาเมื่อกด W
        if (Input.GetKeyDown(throwKey))
        {
            ThrowProjectile();
        }
    }

    void ThrowProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, throwPoint.position, Quaternion.identity);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.AddForce(throwDirection.normalized * 500f);
    }
}
