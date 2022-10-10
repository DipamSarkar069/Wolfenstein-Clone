using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenFirst : MonoBehaviour
{
    public GameObject door;

    void OnTriggerEnter(Collider other)
    {
        door.GetComponent<Animator>().Play("Door Movement");
    }
}
