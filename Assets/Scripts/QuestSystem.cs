using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestSystem : MonoBehaviour
{
    public Text feedMeLW;
    public Text feedMeLP;
    public Text feedMeR;
    public Text feedMeJ;
    public Text feedMeUT;
    public Text feedMeAS;
    public Text feedMeG;
    public Text feedMeASOG;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("HighScore") >= 10) { feedMeLW.text = "Full";}
        if (PlayerPrefs.GetInt("HighScore") >= 20) { feedMeLP.text = "Full";}
        if (PlayerPrefs.GetInt("HighScore") >= 30) { feedMeR.text = "Full";}
        if (PlayerPrefs.GetInt("HighScore") >= 40) { feedMeJ.text = "Full";}
        if (PlayerPrefs.GetInt("HighScore") >= 50) { feedMeUT.text = "Full";}
        if (PlayerPrefs.GetInt("HighScore") >= 75) { feedMeAS.text = "Full";}
        if (PlayerPrefs.GetInt("HighScore") >= 100) { feedMeG.text = "Full";}
        if (PlayerPrefs.GetInt("HighScore") >= 500) { feedMeASOG.text = "Full";}
    }
}
