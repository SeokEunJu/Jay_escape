using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene03_right : MonoBehaviour
{
    public void move_right(){
        SceneManager.LoadScene("Scene04");
    }
}