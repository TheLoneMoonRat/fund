using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Signer : MonoBehaviour
{
    // Start is called before the first frame update
    public void switchScene () {
        SceneManager.LoadScene("Sign in");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
