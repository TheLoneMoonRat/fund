using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class incomeSubmitter : MonoBehaviour
{
    public Image inputer;
    public Text placeHolder;
    public void Start () {
        inputer.enabled = false;
        placeHolder.enabled = false;
    }
    public void incomeSurveyer () {
        inputer.enabled = true;
        placeHolder.enabled = true;
    }
}
