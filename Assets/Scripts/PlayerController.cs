using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    private Rigidbody rb;
    public Text scoreboard;
    private int score = 0;

    [SerializeField] private float speed = 20f;
    [SerializeField] private float xLimit = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        rb.MovePosition(transform.position + new Vector3(horizontalInput, 0, 0) * speed * Time.deltaTime);
        if (transform.position.x > xLimit) transform.position = new Vector3(xLimit, transform.position.y, transform.position.z);
        else if (transform.position.x < -xLimit) transform.position = new Vector3(-xLimit, transform.position.y, transform.position.z);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rock"))
        {
            Destroy(other.gameObject);
            score += 1;
            scoreboard.text = score.ToString();
        }
        else if(other.CompareTag("Power")) 
        {
            StartCoroutine("PowerUp");
        }
    }

    IEnumerator PowerUp()
    {
        transform.localScale = new Vector3(transform.localScale.x * 2, transform.localScale.y, transform.localScale.z);
        yield return new WaitForSeconds(6f);
        transform.localScale = new Vector3(transform.localScale.x / 2, transform.localScale.y, transform.localScale.z);
    }

}
