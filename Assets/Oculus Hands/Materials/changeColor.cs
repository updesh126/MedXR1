using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public Material material;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ColorRgb()
    {
        material.color = color;
    }
}
