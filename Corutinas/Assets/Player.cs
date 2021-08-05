using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float mag = 2;
    [SerializeField] GameObject gameover;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");

        Vector3 mov = transform.forward * x * -1;
        Vector3 movement = mov.normalized * mag;
        rb.AddForce(movement);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Esfera")
        {
            gameover.SetActive(true);
            Destroy(gameObject);
        }
    }
}
