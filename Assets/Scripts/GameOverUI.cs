using UnityEngine;

// Muestra la interfaz de Game Over cuando la pelota cae por debajo de la paleta.
// No modifica los scripts existentes: observa la pelota (boolmovement) por su cuenta.
public class GameOverUI : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] float loseY = -5.6f;

    Transform ball;
    Collider2D ballCollider;
    bool isGameOver;

    void Start()
    {
        Time.timeScale = 1f;
        if (panel != null) panel.SetActive(false);

        boolmovement ballScript = FindFirstObjectByType<boolmovement>();
        if (ballScript != null)
        {
            ball = ballScript.transform;
            ballCollider = ballScript.GetComponent<Collider2D>();
        }
    }

    void Update()
    {
        if (isGameOver || ball == null) return;

        float bottom = ballCollider != null ? ballCollider.bounds.min.y : ball.position.y;
        if (bottom < loseY)
        {
            isGameOver = true;
            if (panel != null) panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
