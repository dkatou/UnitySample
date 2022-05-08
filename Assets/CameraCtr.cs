using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtr : MonoBehaviour
{
    GameObject Cube;
    GameObject Sphere;
    // Start is called before the first frame update
    void Start()
    {
        Cube = GameObject.Find("Cube");
        Sphere = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion qua = Cube.transform.rotation;
        Vector3 vec = Sphere.transform.position;

        transform.rotation = new Quaternion(qua.x, qua.y, qua.z, qua.w);
        transform.position = new Vector3(vec.x, transform.position.y, transform.position.z);

    }
}
