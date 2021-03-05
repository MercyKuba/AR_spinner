using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switching : MonoBehaviour
{
    public GameObject a;
    public GameObject b;



    // Start is called before the first frame update
    void Start()
    {
        ToggleModel();
    }

    // Update is called once per frame
    void Update(){       
        

        if (Input.GetKeyDown(KeyCode.K))
        {
            ToggleModel();
        }

     

    }
    void ToggleModel()

    {
        Debug.Log("Test");
        a.SetActive(!a.activeSelf);
        b.SetActive(!b.activeSelf);

    }
}
