using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooglyButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPress() {
        PlayerPrefs.SetInt("color", 101);
        Debug.Log("Skin is now googly");
    }
}
