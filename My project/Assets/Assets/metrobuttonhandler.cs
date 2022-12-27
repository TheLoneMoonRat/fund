using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class metrobuttonhandler : MonoBehaviour
{
    // Start is called before the first frame update
    public void scenechange () {
        SceneManager.LoadScene ("metro");
    }
}
