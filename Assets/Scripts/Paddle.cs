using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private bool isPlayer1;
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;
    public Vector3 startPosition;

    private float movement;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        rb.velocity = new Vector2(rb.velocity.x , movement  * speed);
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}