using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class passwordcontroller : MonoBehaviour
{
    public List <string> passwordList;
    public InputField fielder;
    public string password;
    public void checkPassword (int i) {
        password = passwordList[i];
    }
    public void announceIt () {
        if (password == fielder.text) {
            SceneManager.LoadScene("Homepage");
        }
    }

}
