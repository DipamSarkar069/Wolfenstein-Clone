using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAtPlayer : MonoBehaviour
{
    public Transform thePlayer;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(thePlayer);
    }
}
