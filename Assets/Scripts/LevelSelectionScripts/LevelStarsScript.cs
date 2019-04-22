using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarsScript : MonoBehaviour
{
    public int id; // specifies the level id / what level is this
    [SerializeField]private GameObject[] starsChilds; // as the stars is the children button can just put it in array
    private int starsFilled;
    // Start is called before the first frame update
    void Start()
    {
        starsChilds = new GameObject[transform.childCount]; // initialize the stars objects

        // Initialize all the empty stars
        for (int i = 0; i < transform.childCount; i++)
        {
            starsChilds[i] = transform.GetChild(i).gameObject;
        }

        // PlayerPrefs.SetInt("stars" + id.ToString(), 1);
       
        // check the id / if id star same with stars id proceed
        if (PlayerPrefs.GetInt("stars" + id.ToString()) == id)
        {
            // check level stars that the player won
            // get the number
            starsFilled = PlayerPrefs.GetInt("stars" + id.ToString() + "fills");
           
            for(int i = 0; i < starsFilled; i++)
            {
                foreach(Transform filled in starsChilds[i].transform)
                {
                    Debug.Log(filled.gameObject.name);
                    filled.gameObject.SetActive(true);
                }
            }

        }
    }

}
