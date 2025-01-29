using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    public ProjectileBehaviour ProjectilePrefab;
    public Transform LaunchOffset;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        if(Input.GetKey("d"))
        {
            newPosition.x += .05f;
        }
        if(Input.GetKey("a"))
        {
            newPosition.x -= .05f;
        }
        if(Input.GetKey("w"))
        {
            newPosition.y += .05f;
        }
         transform.position = newPosition;

         if(Input.GetKey("g"))
         {
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
         }
        
    }
}
