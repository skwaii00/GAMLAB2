using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 10f;
    public float boundary = 8f;
    private float facingDirection = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bat dau");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        Vector3 moveDirection = new Vector3(moveInput, 0, 0);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        Vector3 currentPosition = transform.position;

        if (currentPosition.x < -boundary)
        {
            currentPosition.x = -boundary;
        }
        else if (currentPosition.x > boundary)
        {
            facingDirection = 1;
            currentPosition.x = boundary;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            facingDirection = -1;
            Debug.Log("You Press A moving to Left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            facingDirection = 1;
            Debug.Log("You Press D moving to Right");
        }

        Vector3 newScale = transform.localScale;
        newScale.x = facingDirection;
        transform.localScale = newScale;
        transform.position = currentPosition;
    }
}