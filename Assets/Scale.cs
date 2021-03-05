using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
    public GameObject form;
    public Slider scale;
    public float previousValue;
    // Start is called before the first frame update
    void Start()
    {
        this.scale.onValueChanged.AddListener(this.OnSliderChanged);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnSliderChanged(float value)
    {
        
        
            form.transform.localScale = new Vector3(value, value, value);

       
    }
}
