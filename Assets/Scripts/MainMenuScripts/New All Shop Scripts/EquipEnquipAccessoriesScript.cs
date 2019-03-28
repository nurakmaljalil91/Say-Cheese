using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipEnquipAccessoriesScript : MonoBehaviour
{

    private GameObject equipText;
    // private GameObject unequipText;

    public bool hat;
    public bool bagpack;

    public int id;

    private bool onOffSwitch;
    // Use this for initialization
    void Start()
    {

        // unequipText = transform.GetChild(0).gameObject;
        equipText = transform.GetChild(1).gameObject;

    }

    // Update is called once per frame
    void Update()
    {

        // CheckOtherIfItemEquip();
    }

    public void OnChangeValue()
    {

        onOffSwitch = transform.gameObject.GetComponent<Toggle>().isOn;

        if (onOffSwitch)
        {
            equipText.SetActive(true);
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
        if (!onOffSwitch)
        {
            equipText.SetActive(false);
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
        Debug.Log(PlayerPrefs.GetInt("bag"));

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
                if (!equipText)
                {
                    equipText.SetActive(true);
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
                if (!equipText)
                {
                    equipText.SetActive(true);
                }

            }
        }

    }
}
