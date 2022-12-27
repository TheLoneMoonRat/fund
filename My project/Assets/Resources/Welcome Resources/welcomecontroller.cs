using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class welcomecontroller : MonoBehaviour
{
    public void tosurvey () {
        SceneManager.LoadScene("IncomeSurvey");
    }
}
