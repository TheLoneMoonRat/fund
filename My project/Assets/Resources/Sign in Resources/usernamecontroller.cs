using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class usernamecontroller : MonoBehaviour
{
    public passwordcontroller other;
    static List<string> userNames  = new List<string> { "Evelyn", "David", "Kaia", "Kieran", "Daria", "Nick", "Nathan", "Rand" };
    public InputField infield;
    // Start is called before the first frame update
    public void usernamechecker () {
        if (userNames.Contains(infield.text)) {
                other.checkPassword(userNames.IndexOf(infield.text));
        } else {
            Debug.Log("WRONG");
        }
    }
    // public void giveme () {
    //     return userNames[0];
    // }
}
