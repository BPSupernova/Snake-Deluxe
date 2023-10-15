using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public void PauseThisGame() {
        if(Time.timeScale == 1f||Time.timeScale == 1.5f) { Time.timeScale = 0f; }
        else { Time.timeScale = 1f; }
    }
}
