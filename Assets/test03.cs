using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test03 : MonoBehaviour
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
        Vector3 vec = Sphere.transform.position;

        this.transform.rotation = Cube.transform.rotation;
        //this.transform.rotation = Quaternion.Euler(0, 0, Input.acceleration.x * -90);
        this.transform.position = new Vector3(vec.x, vec.y, transform.position.z);
    }
}
