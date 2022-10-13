using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandgunAmmoPickup : MonoBehaviour
{
    
    public GameObject fakeAmmo;
    public AudioSource AmmoPickup;
    public GameObject pickUpDisplay;

    void OnTriggerEnter(Collider other)
    {
        
        fakeAmmo.SetActive(false);
        AmmoPickup.Play();
        GlobalAmmoCount.maxAmmo += 10;
        GetComponent<BoxCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "Picked up a Hand-Gun Ammo";
        pickUpDisplay.SetActive(true);
    }
}
