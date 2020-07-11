using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnIf : MonoBehaviour
{
    public bool test;
    // Start is called before the first frame update
    void Start()
    {
        if (test)
        {
            print("123");
        }
    }
    public bool opendoor;
    // Update is called once per frame
    void Update()
    {
        if (opendoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }
    }
}
