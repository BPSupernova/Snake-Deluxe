using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTrailScript : MonoBehaviour
{
    //private SnakeManager snakeManager;
    private int colorInt;
    public TrailRenderer trailRenderer;
    // Start is called before the first frame update
    void Start()
    {
        colorInt = PlayerPrefs.GetInt("color");
        if (colorInt <= 99) {
        trailRenderer.startColor = SnakeManager.colorsArray[colorInt];
        }
        else {
            if (colorInt == 100) {
                trailRenderer.startColor = SnakeManager.colorsArray[1];
            }
            else if (colorInt == 101) {
                trailRenderer.startColor = SnakeManager.colorsArray[0];
            } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
