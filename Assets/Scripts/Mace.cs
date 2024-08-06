using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mace : MonoBehaviour
{
    public float speed = 0.8f;
    public float range = 3;
    int dir = 1;

    float startingY;
    // Start is called before the first frame update
    void Start()
    {
        startingY = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.up*speed*Time.fixedDeltaTime*dir);
        if(transform.position.y>startingY+range|| transform.position.y<startingY){
            dir*=-1;
        }
    }
}
