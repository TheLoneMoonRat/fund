using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttoncaller : MonoBehaviour
{
    // Start is called before the first frame update
    public void changescene () {
        SceneManager.LoadScene ("Sign in");
    }
}
