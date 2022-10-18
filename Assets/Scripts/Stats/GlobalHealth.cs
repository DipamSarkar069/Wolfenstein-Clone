using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    public GameObject healthDisplay;
    public static int healthValue;

    // Start is called before the first frame update
    void Start()
    {
        healthValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(healthValue<=0)
        {
            SceneManager.LoadScene(1);
        }
        healthDisplay.GetComponent<Text>().text = "" + healthValue + "%";
    }
}
