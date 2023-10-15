using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMain : MonoBehaviour
{
    public Snake snake;
    private int i = 0;
    public string scene;
    public int timeLimit;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        i++;
            if (i == timeLimit) {
            SceneManager.LoadScene(scene);
            }

    }
}
