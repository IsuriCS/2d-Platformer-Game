using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public Transform mainCam;
    public Transform middleBG;
    public Transform sideBG;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(mainCam.position.x > middleBG.position.x )
        {
           sideBG.position = middleBG.position +Vector3.right * 38.4f;
        }
        if(mainCam.position.x < middleBG.position.x )
        {
            sideBG.position = middleBG.position + Vector3.left * 38.4f;
        }

        if(mainCam.position.x > sideBG.position.x || mainCam.position.x < sideBG.position.x)
        {
            Transform temp = middleBG;
            middleBG = sideBG;
            sideBG = temp;
        }
    }
}
