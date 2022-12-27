using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class incomeStorer : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField inputguy;
    public List<string> incomes;
    public void inputIncome () {
        incomes.Add(inputguy.text);
        Debug.Log(incomes[0]);
    }
}
