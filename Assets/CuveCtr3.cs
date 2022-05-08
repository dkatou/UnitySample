using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuveCtr3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float fZ;
        fZ = Input.acceleration.x;

        this.transform.localRotation = Quaternion.Euler(0, 0, fZ * -90);
    }
}
