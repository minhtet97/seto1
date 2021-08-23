using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falldown : MonoBehaviour
{
    public Transform player;
    public Transform elevatorswitch;
    public Transform downpos;
    public Transform uppos;

    public float speed;
    bool iselevatordown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartElevator();
    }

    void StartElevator()
    {
        if(Vector2.Distance(player.position,elevatorswitch.position)<0.5f && Input.GetKeyDown("space"))
        {
            if(transform.position.y <= downpos.position.y)
            {
                iselevatordown = true;
            }
            else if(transform.position.y >= uppos.position.y)
            {
                iselevatordown = false;
            }
        }

        if(iselevatordown)
        {
            transform.position = Vector2.MoveTowards(transform.position,uppos.position,speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position,downpos.position,speed * Time.deltaTime);
        }

       /* if(Input.GetKeyDown("e"))
        {
            iselevatordown = true;
        }
        else
        {
            iselevatordown = false;
        }*/
    }
}
