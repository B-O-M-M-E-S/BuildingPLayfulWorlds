using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    int endscore;
    int score = 10;
    int startscore = 0;

    void OnGUI()
    {
        GUI.color = Color.red;
        GUI.Label(new Rect(180, 20, 200, 180), "Score : " + endscore);
    }

    public void AddScore()
    {
        endscore = startscore + score;
    }

    public void EndGame()
    {

        Debug.Log("Game Over");
        Restart();
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
