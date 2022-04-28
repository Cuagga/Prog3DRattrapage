using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TexteC : MonoBehaviour
{
    public ControlText stats;
    Text txt;

    void Start()
    {
        stats.kills = 0;
        stats.fails = 0;
        stats.shot = 0;
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        txt.text = "Cibles touchées : " + stats.kills + " ; Echecs : " + stats.fails;
    }
}
