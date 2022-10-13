using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCallUnity : MonoBehaviour
{
    public Text helloText;
    public void HelloUnity(string text){
        helloText.text = text;
    }
}
