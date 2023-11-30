using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private LayerMask groundLayers;
    private bool isGrounded;
    private Vector3 _moveDirection;

    private Rigidbody rb;
    private float depth;

    [Header("player UI")]

    [SerializeField] public TextMeshProUGUI deaths = null;

    


    public int currentDeaths;




    void Start()
    {
        InputManager.Init(this);
        InputManager.SetGameControls();

        rb = GetComponent<Rigidbody>();

        //deaths.text = currentDeaths.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (speed * Time.deltaTime * _moveDirection);
        //deaths.text = currentDeaths.ToString();
        checkGround();
    }


    public void SetMovementDirection(Vector3 currentDirection)
    {
        _moveDirection = currentDirection;
    }

    public void Jump()
    {
        Debug.Log("jomp called");
        if (isGrounded)
        {
            Debug.Log("jomped");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void checkGround()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, GetComponent<Collider>().bounds.size.y);
        Debug.DrawRay(transform.position, Vector3.down * GetComponent<Collider>().bounds.size.y, Color.green, 0, false);
    }

}