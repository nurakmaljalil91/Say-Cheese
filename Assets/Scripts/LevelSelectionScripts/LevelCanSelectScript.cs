using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCanSelectScript : MonoBehaviour
{
    public int id; // get the button id
    private Button theButton; // the button component
    

    // Start is called before the first frame update
    void Start()
    {
        theButton = GetComponent<Button>();
        ColorBlock buttonColor = theButton.colors;

        //PlayerPrefs.SetInt("stars" + id.ToString() + "fills", 0); //for reset
        // check if the stars is zero
        if (PlayerPrefs.GetInt("stars"+id.ToString()+"fills") == 0)
        {
            theButton.interactable = false; // do not let the button to be pressed
                         
        }
        else
        {
            theButton.interactable = true;
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
