using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carcontroller : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 50f;
    public float horizontalInput;
    public float verticalInput;


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        transform.Translate(translation: Vector3.forward * speed * Time.deltaTime * verticalInput);


        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name.Contains("coin"))
        {
            Destroy(other.gameObject);
        }
    }








}
