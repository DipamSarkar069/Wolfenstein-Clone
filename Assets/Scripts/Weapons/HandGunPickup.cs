using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandGunPickup : MonoBehaviour
{
    public GameObject realHandGun;
    public GameObject fakeHandGun;
    public AudioSource GunPickup;
    public GameObject pickUpDisplay;

    void OnTriggerEnter(Collider other)
    {
        realHandGun.SetActive(true);
        fakeHandGun.SetActive(false);
        GunPickup.Play();
        GetComponent<BoxCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "Picked up a Hand-Gun";
        pickUpDisplay.SetActive(true);
    }
}
