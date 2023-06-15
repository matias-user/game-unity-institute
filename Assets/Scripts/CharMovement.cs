using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharMovement : MonoBehaviour
{
    float h;
    float v;
    private Vector2 moveDirection;
    [SerializeField]float speed = 4;
    public bool isMoving => moveDirection.magnitude > 0;
    
    public Vector2 MoveDirection => moveDirection;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {

    }
    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    
        moveDirection.x = h;
        moveDirection.y = v;

        transform.position += (Vector3)moveDirection * Time.deltaTime * speed;
        
    }
    
}
