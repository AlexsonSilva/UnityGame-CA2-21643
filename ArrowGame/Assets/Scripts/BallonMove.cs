using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonMove : MonoBehaviour
{
    //left and right empty gameobjects
    public Transform left;
    public Transform right;
    public Transform top;
    public Transform botton;

    //speed value
    public float speed = 1.0f;

    //current direction - false means left, true means right
    bool dir = false;

    // Update is called once per frame
    void Update()
    {
        if (dir)
        {
            //move closer to right transform
            transform.position = Vector3.MoveTowards(transform.position, right.position,
                speed * Time.deltaTime);

            //has it reached right transform?
            if(transform.position == right.position)
            {
                dir = !dir;//bool flips from true to false
            }
        }
        else if(dir)
        {
            //move closer to left transform
            transform.position = Vector3.MoveTowards(transform.position, left.position,
                speed * Time.deltaTime);

            //has it reached left transform?
            if (transform.position == left.position)
            {
                dir = !dir;//bool flips from true to false
            }
        }


        else if (dir)
        {
            //move closer to top transform
            transform.position = Vector3.MoveTowards(transform.position, top.position,
                speed * Time.deltaTime);

            //has it reached top transform?
            if (transform.position == top.position)
            {
                dir = !dir;//bool flips from true to false
            }
        }
        else
        {
            //move closer to botton transform
            transform.position = Vector3.MoveTowards(transform.position, botton.position,
                speed * Time.deltaTime);

            //has it reached botton transform?
            if (transform.position == botton.position)
            {
                dir = !dir;//bool flips from true to false
            }
        }
    }

}
