using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test01 : MonoBehaviour
{
    float speed = 0.5f;
    float radius = 10.0f;
    GameObject _camera;
    // Start is called before the first frame update
    void Start()
    {
        _camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        float _x;
        float _z;

        _x = radius * Mathf.Sin(Time.time * speed);
        _z = radius * Mathf.Cos(Time.time * speed);

        _camera.transform.position = new Vector3(_x, 0, _z);
        _camera.transform.LookAt(this.gameObject.transform);
    }
}
