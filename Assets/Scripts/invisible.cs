using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisible : MonoBehaviour
{

    public Renderer myRenderer;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
