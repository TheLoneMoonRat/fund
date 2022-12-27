using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class billorganizer : MonoBehaviour
{
    public Image billType;
    public Image billCost;
    public Image billFr;
    public Text textType;
    public Text textCost;
    public Text textFr;
    public Image arrow1;
    public Image arrow2;
    private bool switches;

    // Start is called before the first frame update
    void Start()
    {
        switches = false;
        billType.enabled = false;
        billCost.enabled = false;
        billFr.enabled = false;
        textType.enabled = false;
        textCost.enabled = false;
        textFr.enabled = false;
        arrow1.enabled = false;
        arrow2.enabled = false;
    }

    // Update is called once per frame
    public void reveal ()
    {
        billType.enabled = true;
        billCost.enabled = true;
        billFr.enabled = true;
        textType.enabled = true;
        textCost.enabled = true;
        textFr.enabled = true;
        arrow1.enabled = true;
        arrow2.enabled = true;
    }
}
