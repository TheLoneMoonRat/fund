using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class billcostStorage : MonoBehaviour
{
    public List<int> billCosts;
    public InputField ifield;
    // Start is called before the first frame update
    public void addBillCost () {
        billCosts.Add(Int32.Parse(ifield.text));
    }
}
