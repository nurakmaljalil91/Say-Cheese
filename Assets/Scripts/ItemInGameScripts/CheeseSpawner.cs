using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSpawner : MonoBehaviour
{

    public GameObject cheeseLocation;

    public GameObject cheesePrefab;
    private GameObject cheese;

    private GameObject[] cheeseLocationInArray;

    [SerializeField] private int totalNumberOfCheese;

    private bool cheeseIsInMap;

    private Vector3 randomPosition;

    public GameObject gameFinishPanel;

    // Use this for initialization
    void Start()
    {
        InitTheArrayWithTheLocationOfCheese();
        cheeseIsInMap = false;
        totalNumberOfCheese = 20;
    }

    // Update is called once per frame
    void Update()
    {

        // TODO: Here is where we check in the map wheter 
        // the cheese is exist
        CheckIfTheCheeseIsExistOnMap();
        // check if there is a cheese in the map
        if (!cheeseIsInMap && totalNumberOfCheese != 0)
        {
            // TODO: Generate the random position location
            GenerateRandomLocation();
            // TODO: we spawn the cheese in the random position
            SpawnTheCheese();

        }

        GameIsFinish();



        //Debug.Log("Cheese in Map:" + cheeseIsInMap);
    }

    void InitTheArrayWithTheLocationOfCheese()
    {

        cheeseLocationInArray = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            cheeseLocationInArray[i] = transform.GetChild(i).gameObject;
        }

        // here to make the cheese spawn at the middle of the map at the start of the level
        cheese = Instantiate(cheesePrefab, cheeseLocationInArray[0].transform.position, Quaternion.identity);
    }

    void GenerateRandomLocation()
    {
        int randomNumber = Random.Range(0, transform.childCount);

        randomPosition = cheeseLocationInArray[randomNumber].transform.position;
    }

    void SpawnTheCheese()
    {

        // Instatiate the cheese
        cheese = Instantiate(cheesePrefab, randomPosition, Quaternion.identity);
        cheeseIsInMap = true;
        totalNumberOfCheese--;
    }

    void CheckIfTheCheeseIsExistOnMap()
    {
        if (cheese)
        {
            cheeseIsInMap = true;
        }
        else
        {
            cheeseIsInMap = false;
        }
    }

    void GameIsFinish()
    {
        if (totalNumberOfCheese == 0)
        {
            gameFinishPanel.SetActive(true);
            Time.timeScale = 0;
        }

    }

}
