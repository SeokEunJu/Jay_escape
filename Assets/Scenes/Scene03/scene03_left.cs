using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene03_left : MonoBehaviour
{
    public void move_left(){
        SceneManager.LoadScene("Scene02");
    }
}