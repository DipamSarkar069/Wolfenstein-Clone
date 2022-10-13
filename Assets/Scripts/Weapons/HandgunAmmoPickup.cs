using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunAmmoPickup : MonoBehaviour
{
    
    public GameObject fakeAmmo;
    public AudioSource AmmoPickup;

    void OnTriggerEnter(Collider other)
    {
        
        fakeAmmo.SetActive(false);
        AmmoPickup.Play();
        GlobalAmmoCount.maxAmmo += 10;
        
    }
}
