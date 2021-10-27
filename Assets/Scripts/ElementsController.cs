using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsController : MonoBehaviour
{

    private Rigidbody rb;
    [SerializeField] float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5f) Destroy(this.gameObject);
        rb.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);
    }
}
