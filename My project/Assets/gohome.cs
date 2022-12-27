using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gohome : MonoBehaviour
{
    // Start is called before the first frame update
    public void goHome () {
        SceneManager.LoadScene("Welcome");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
