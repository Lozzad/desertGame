using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour {
    public float height = 50;
    public float distance = 80;
    public float rotationSpeed = 5;

    // Start is called before the first frame update
    void Start () {
        transform.position = new Vector3 (distance, height, distance);
    }

    // Update is called once per frame
    void Update () {
        transform.RotateAround (Vector3.zero, Vector3.up, rotationSpeed * Time.deltaTime);

    }

}