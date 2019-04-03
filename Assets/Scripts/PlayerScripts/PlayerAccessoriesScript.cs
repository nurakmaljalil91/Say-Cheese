using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAccessoriesScript : MonoBehaviour
{

    private int hat;

    private int bag;
    // Use this for initialization
    void Start()
    {
        // TODO: Player top hat will determine by the 
        // if zero so no items attached
        // maybe can use switch here
        // PlayerPrefs.SetInt("hat",0); //for reset
        // PlayerPrefs.SetInt("bag",0); // for reset

        hat = PlayerPrefs.GetInt("hat");
        bag = PlayerPrefs.GetInt("bag");
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            if (bag == 1)
            {
                if (transform.GetChild(i).name.Equals("bag01"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            if (bag == 2)
            {
                if (transform.GetChild(i).name.Equals("bag02"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            if (bag == 3)
            {
                if (transform.GetChild(i).name.Equals("bag03"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            if (hat == 1)
            {
                if (transform.GetChild(i).name.Equals("cap01"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            if (hat == 2)
            {
                if (transform.GetChild(i).name.Equals("cap02"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            if (hat == 3)
            {
                if (transform.GetChild(i).name.Equals("cap03"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            if (hat == 4)
            {
                if (transform.GetChild(i).name.Equals("crown04"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            if (hat == 5)
            {
                if (transform.GetChild(i).name.Equals("crown05"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            if (hat == 6)
            {
                if (transform.GetChild(i).name.Equals("crown06"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            if (hat == 7)
            {
                if (transform.GetChild(i).name.Equals("ribbon07"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            if (hat == 8)
            {
                if (transform.GetChild(i).name.Equals("ribbon08"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            if (hat == 9)
            {
                if (transform.GetChild(i).name.Equals("ribbon09"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            if (hat == 10)
            {
                if (transform.GetChild(i).name.Equals("tophat10"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            if (hat == 11)
            {
                if (transform.GetChild(i).name.Equals("tophat11"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            if (hat == 12)
            {
                if (transform.GetChild(i).name.Equals("tophat12"))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
        }

        // for(int i = 0; i < )

    }

    // Update is called once per frame
    void Update()
    {

    }
}
