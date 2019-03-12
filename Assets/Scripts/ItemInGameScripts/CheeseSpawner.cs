using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSpawner : MonoBehaviour
{

    public GameObject cheeseLocation;

    public GameObject cheesePrefab;
    private GameObject cheese;

    private GameObject[] cheeseLocationInArray;



    private bool cheeseIsInMap;

    private Vector3 randomPosition;

    // Use this for initialization
    void Start()
    {
        InitTheArrayWithTheLocationOfCheese();
        cheeseIsInMap = false;
    }

    // Update is called once per frame
    void Update()
    {

        // TODO: Here is where we check in the map wheter 
        // the cheese is exist
        CheckIfTheCheeseIsExistOnMap();
        // check if there is a cheese in the map
        if (!cheeseIsInMap)
        {
            // TODO: Generate the random position location
            GenerateRandomLocation();
            // TODO: we spawn the cheese in the random position
            SpawnTheCheese();

        }



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

}
