using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCtr : MonoBehaviour
{
    Rigidbody rgd;
    float baseTorque = 10.0f;
    float maxTorque = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        rgd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) { key = -1; }
        if (Input.GetKey(KeyCode.LeftArrow)) { key = 1; }

        float fTorque = Mathf.Abs(rgd.rotation.x);

        if (fTorque < maxTorque)
        {
            rgd.AddTorque(transform.forward * key * baseTorque);
        }
    }
}
