using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuteHamsterRotate : MonoBehaviour
{

    private RectTransform rectangle;

    private Vector3 rotationEuler;

    // Use this for initialization
    void Start()
    {
        rectangle = GetComponent<RectTransform>();
    }


    // Update is called once per frame
    void Update()
    {
        // rectangle.
        // Calculate angle of the image
        rotationEuler += Vector3.forward * 5 * Time.deltaTime; // increment 5 degress every seconds



        //TODO: if the rotation is not 45

        if (rectangle.rotation.z <= 0.5)
        {
            rectangle.rotation = Quaternion.Euler(rotationEuler);

        }

        //Debug.Log(rectangle.rotation.eulerAngles);


    }



}
