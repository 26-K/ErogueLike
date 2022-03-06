using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMove : MonoBehaviour
{
    float speed = 10.0f;
    Rigidbody rgd;
    private void Start()
    {
        rgd = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(this.transform.position.x,  this.transform.position.y, this.transform.position.z + 1 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 1 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(this.transform.position.x + 1 * speed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(this.transform.position.x - 1 * speed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rgd.AddForce(Vector3.up * 250);
        }
    }
}
