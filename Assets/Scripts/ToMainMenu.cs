using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToMainMenu : MonoBehaviour
{
    public Snake snake;
    // Start is called before the first frame update
    public void SceneLoader(int SceneIndex)
    {
        snake.ResetState();
        SceneManager.LoadScene(SceneIndex);
    }
}
