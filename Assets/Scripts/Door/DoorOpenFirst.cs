using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenFirst : MonoBehaviour
{
    public GameObject door;
    public AudioSource doorFX;

    void OnTriggerEnter(Collider other)
    {
        doorFX.Play();
        door.GetComponent<Animator>().Play("Door Open");
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(5);
        doorFX.Play();
        door.GetComponent<Animator>().Play("Door Close");
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
