using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* isPink must be set to "true" when the button is clicked
 otherwise you should probably just delete everything nonessential
*/

public class PinkButtonDummyScript : MonoBehaviour
{
    public bool isPink = false;
    void Start()
    {
        //Button pinkButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPress()
    {
        isPink = true;
        PlayerPrefs.SetInt("color", 6);
        Debug.Log("Skin is now pink");
    }
}
