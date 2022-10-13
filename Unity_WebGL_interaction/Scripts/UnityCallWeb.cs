using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
public class UnityCallWeb : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void HelloWeb();
    void Start() {
        HelloWeb();  
    }
}
