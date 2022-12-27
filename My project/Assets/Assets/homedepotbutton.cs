using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class homedepotbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public void changescene () {
        SceneManager.LoadScene ("homedepot");
    }
}
