using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {
    public float speed = 10f;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        transform.RotateAround (Vector3.zero, Vector3.right, speed * Time.deltaTime);
        transform.LookAt (Vector3.zero);
        //transform.Rotate (0, 20 * Time.deltaTime, 0);
    }
}