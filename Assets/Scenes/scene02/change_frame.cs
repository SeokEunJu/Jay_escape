using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change_frame : MonoBehaviour
{
    public int num = 0;
    public Sprite img2;
    public Sprite img3;

    public void changeImg(){
        if(num == 0){
            GameObject.Find("frame_hint").GetComponent<Image> ().sprite = img2;
            num++;
        }
        else if(num == 1){
            GameObject.Find("frame_hint").GetComponent<Image> ().sprite = img3;
        }
    }

}
