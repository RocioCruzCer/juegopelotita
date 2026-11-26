using UnityEngine;

public class ballCollision : MonoBehaviour
{
    GameManager gameManager;
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("block"))
        {
            Destroy(collision.gameObject);
            gameManager.DecreaseBlock();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.RestartGame();
    }
}
