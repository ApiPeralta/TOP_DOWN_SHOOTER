using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayer : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 movement;
    private Vector3 mousePos;
    public float speed = 5f;
    private Vector3 startPos;
    private Renderer render;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPos = this.transform.position;
        rb = GetComponent<Rigidbody>();
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        movement.x = Input.GetAxis("secondH");
        movement.z = Input.GetAxis("secondV");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void Movement()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        transform.LookAt(new Vector3(mousePos.x, 1, mousePos.z));
    }
}
