
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public void EndGame ()
    {
        Debug.Log("GAME OVER");
        SceneManager.LoadScene(0);

    }
}
