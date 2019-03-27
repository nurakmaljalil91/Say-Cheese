using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipEnquipAccessoriesScript : MonoBehaviour
{

    private GameObject equipImage;
    private GameObject unequipImage;

    public bool hat;
    public bool bagpack;

    public int id;

    private bool onOffSwitch;
    // Use this for initialization
    void Start()
    {

        unequipImage = transform.GetChild(0).gameObject;
        equipImage = transform.GetChild(1).gameObject;

    }

    // Update is called once per frame
    void Update()
    {

        CheckOtherIfItemEquip();
    }

    public void OnChangeValue()
    {

        onOffSwitch = transform.gameObject.GetComponent<Toggle>().isOn;

        if (onOffSwitch)
        {
            equipImage.SetActive(true);
            if (hat)
            {
                PlayerPrefs.SetInt("hat", 0);

                // Debug.Log("Player wear hat with " + PlayerPrefs.GetInt("hat"));
            }
            if (bagpack)
            {
                PlayerPrefs.SetInt("bag", 0);

                // Debug.Log("Player wear bag with " + PlayerPrefs.GetInt("bag"));
            }
        }
        if (!onOffSwitch)
        {
            equipImage.SetActive(false);
            if (hat)
            {
                PlayerPrefs.SetInt("hat", id);
                // Debug.Log("Player wear hat with " + PlayerPrefs.GetInt("hat"));
            }
            if (bagpack)
            {

                PlayerPrefs.SetInt("bag", id);

                // Debug.Log("Player wear bag with " + PlayerPrefs.GetInt("bag"));
            }
        }


    }

    void CheckOtherIfItemEquip()
    {

        if (hat)
        {
            if (this.id != PlayerPrefs.GetInt("hat"))
            {
                if (!transform.gameObject.GetComponent<Toggle>().isOn)
                {
                    transform.gameObject.GetComponent<Toggle>().isOn = true;
                }
                if (!equipImage)
                {
                    equipImage.SetActive(true);
                }
            }
        }
        if (bagpack)
        {
            if (this.id != PlayerPrefs.GetInt("bag"))
            {

                if (!transform.gameObject.GetComponent<Toggle>().isOn)
                {
                    transform.gameObject.GetComponent<Toggle>().isOn = true;
                }
                if (!equipImage)
                {
                    equipImage.SetActive(true);
                }

            }
        }

    }
}
