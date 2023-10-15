using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeManager : MonoBehaviour
{
    public static SnakeManager sm;
    public PinkButtonDummyScript pb;
    public static int apples = 0;
    static Color purple = new Color(0.35f, 0.2f, 0.65f);
    static Color orange = new Color(0.99f, 0.6f, 0.2f);
    public static UnityEngine.Color[] colorsArray = new UnityEngine.Color[] {Color.white, Color.red, Color.yellow,
    Color.green, Color.cyan, Color.blue, Color.magenta, purple, orange};
    public static int skinNum = 4;
    // Start is called before the first frame update
    void Awake() {
        sm = this;
        DontDestroyOnLoad(transform.gameObject);
        PlayerPrefs.SetInt("color", 6);
    }
    void Start()
    {
        /*UnityEngine.Color[] colorsArray = new UnityEngine.Color[] {Color.white, Color.red, Color.yellow,
        Color.green, Color.cyan, Color.blue, Color.magenta};*/
        SceneManager.LoadScene("SnakeBuild", LoadSceneMode.Additive);
        Debug.Log("loaded SnakeBuild");
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active scene: " + scene.name);
        /*if (pb.isPink) {
            skinNum = 6;
            Debug.Log("Skin is pink (SnakeManager)");
        }*/
    }

    public static void doSomething() {
        Debug.Log("doing something");
    }
}
