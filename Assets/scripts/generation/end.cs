using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    public int limit;
    public int gen;
    public bool continue_gen = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gen >= limit)
        {
            continue_gen = false;
        }
    }
}
