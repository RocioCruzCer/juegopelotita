using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int blocksLeft;
    private void Start()
    {
        blocksLeft = GameObject.FindGameObjectsWithTag("block").Length;
        Debug.Log(blocksLeft);
    }
    public void DecreaseBlock()
    {
        blocksLeft -= 1;
        Debug.Log("Quedan: " + blocksLeft + " bloques en el juego");
        if (blocksLeft == 0)
        {
            NextScene();
            Debug.Log("Pasar al siguiente nivel");
        }
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
