using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backbuttons : MonoBehaviour
{
    public void whenPressed () {
        SceneManager.LoadScene ("Welcome");
    }
}
