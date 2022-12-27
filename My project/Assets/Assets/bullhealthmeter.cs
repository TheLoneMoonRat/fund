using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullhealthmeter : MonoBehaviour
{
    public Transform healthboar;
    public int a;
    // Update is called once per frame
    void Update()
    {
        healthboar.Translate(-(a), 0, 0);
    }
}
