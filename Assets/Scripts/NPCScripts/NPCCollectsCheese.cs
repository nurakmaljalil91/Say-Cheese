using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCCollectsCheese : MonoBehaviour
{
    [SerializeField] private int NumberOfCheese;

    private GameObject audioManager;
    // Use this for initialization

    public Text cheeseScoreText;
    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager");
        NumberOfCheese = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cheeseScoreText.text = gameObject.tag.ToString() + " : " + NumberOfCheese;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Cheese"))
        {
            audioManager.GetComponent<AudioManagerScripts>().PlaySound("Eat");
            Destroy(other.gameObject);
            NumberOfCheese++;
        }
    }
}
