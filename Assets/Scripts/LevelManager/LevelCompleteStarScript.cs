using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteStarScript : MonoBehaviour
{

    public LevelManagerScript levelManager;
    private GameObject player;

    private float timeComplete;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    public int unlockLevel;

    private GameObject audioManager;

    private int currentGoldAmount;

    private bool checkTime = false;

    private bool playWinningSound = false;

    private bool playStarSound = false;

    private bool increaseGold = false;
    // Use this for initialization
    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager");
        Debug.Log("Start is okay..");
        player = GameObject.FindGameObjectWithTag("Player");
        currentGoldAmount = PlayerPrefs.GetInt("Gold");
    }


    // Update is called once per frame
    void Update()
    {

        if (transform.gameObject.activeSelf)
        {
            //check the time complete
            checkTime = true;

        }

        if (checkTime)
        {
            timeComplete = levelManager.levelTime;
            
            // audioManager.GetComponent<AudioSource>().Stop();
            playWinningSound = true;
            playStarSound = true;
            checkTime = false;
        }

        if(player.GetComponent<PlayerCollectCheese>().GetCheese() > 7)
        {
            if (timeComplete > 180f && timeComplete < 400f)
            {
                // Get 1 Star
                star1.SetActive(true);
                PlayerPrefs.SetInt("level", unlockLevel);
                PlayWinSound();
                PlayStarsSound(1);
                if (!increaseGold)
                {
                    currentGoldAmount += 5;
                    PlayerPrefs.SetInt("Gold", currentGoldAmount);
                    increaseGold = true;
                }


            }
            if (timeComplete >= 60f && timeComplete <= 179f)
            {
                // Get 2 Star
                star1.SetActive(true);
                star2.SetActive(true);
                PlayerPrefs.SetInt("level", unlockLevel);
                PlayWinSound();
                PlayStarsSound(2);
                if (!increaseGold)
                {

                }

            }

            if (timeComplete < 59f)
            {
                // Get 3 Star
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                PlayerPrefs.SetInt("level", unlockLevel);
                if (!increaseGold)
                {
                    currentGoldAmount += 15;
                    PlayerPrefs.SetInt("Gold", currentGoldAmount);
                    increaseGold = true;
                }
                PlayWinSound();
                PlayStarsSound(3);

            }
        }

      
    }

    void PlayWinSound()
    {
        if (playWinningSound)
        {
            audioManager.GetComponent<AudioSource>().PlayOneShot(audioManager.GetComponent<AudioManagerScripts>().sounds[7].clip, 1);
            playWinningSound = false;
        }
    }

    void PlayStarsSound(int noOfStar)
    {
        if (playStarSound)
        {
            if (noOfStar == 1)
            {
                audioManager.GetComponent<AudioSource>().PlayOneShot(audioManager.GetComponent<AudioManagerScripts>().sounds[4].clip, 1);
                playStarSound = false;
            }
            if (noOfStar == 2)
            {
                audioManager.GetComponent<AudioSource>().PlayOneShot(audioManager.GetComponent<AudioManagerScripts>().sounds[5].clip, 1);
                playStarSound = false;
            }
            if (noOfStar == 3)
            {
                audioManager.GetComponent<AudioSource>().PlayOneShot(audioManager.GetComponent<AudioManagerScripts>().sounds[6].clip, 1);
                playStarSound = false;
            }
        }
    }


}
