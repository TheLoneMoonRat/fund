using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttoncontrol2: MonoBehaviour
{
    // Start is called before the first frame update
    public void changescene () {
        SceneManager.LoadScene ("CategoriesSurvey");
    }
}
