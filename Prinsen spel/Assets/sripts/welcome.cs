using UnityEngine.SceneManagement;
using UnityEngine;

public class welcome : MonoBehaviour
{
  public void StartGane()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
