using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inf : MonoBehaviour
{
    GameObject infTxt;
    Text txt;
    Text ttt;
    // Start is called before the first frame update
    void Start()
    {
        infTxt = GameObject.Find("infTxt");
        txt = infTxt.GetComponent<Text>();
        ttt = GameObject.Find("Text").GetComponent<Text>();
        if (SystemInfo.supportsGyroscope)
        {
            ttt.text = "support";
        }
        else
        {
            ttt.text = "not support";
        }
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion qt = Input.gyro.attitude;

        Vector3 acc = Input.acceleration;

        txt.text = "\n";
        txt.text += qt.x.ToString() + "\n" + qt.y.ToString() + "\n" + qt.z.ToString() + "\n" + qt.w.ToString();
        txt.text += "\n";
        txt.text += acc.x.ToString() + "\n" + acc.y.ToString() + "\n" + acc.z.ToString();



        //infTxt.GetComponent<Text>().text = "1";
    }
}
