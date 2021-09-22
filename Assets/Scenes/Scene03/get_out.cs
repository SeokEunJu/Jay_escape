using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class get_out : MonoBehaviour
{
    public InputField field;

    public void check(){
        if(field.text == "7125"){
            SceneManager.LoadScene("Complete");
        }
    }
}
