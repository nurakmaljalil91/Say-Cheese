using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public GameObject powerUpPrefab;

    private GameObject powerUp;

    [SerializeField] private GameObject[] powerUpLocation;

    public float durationForSpawn = 15;

	private Vector3 randomPosition;

    // Use this for initialization
    void Start()
    {
        powerUpLocation = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            powerUpLocation[i] = transform.GetChild(i).gameObject;
        }

    }

    // Update is called once per frame
    void Update()
    {
		// Debug.Log(durationForSpawn);
		GenerateRandomLocation();
		SpawnThePowerUp();
    }

	// Generate random location
	private void GenerateRandomLocation(){
		int randomNumber = Random.Range(0, transform.childCount);

		randomPosition = powerUpLocation[randomNumber].transform.position;
	}

	private void SpawnThePowerUp(){
		durationForSpawn -= Time.deltaTime;

		if(durationForSpawn < 0){
			powerUp = Instantiate(powerUpPrefab,randomPosition, Quaternion.identity );
			durationForSpawn = 15;
		}

		
	}
}
