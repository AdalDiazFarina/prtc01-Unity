using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public int rotation_ = 50;
   
    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A)) {
            this.transform.Rotate(new Vector3(0, -rotation_ ,0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D)) {
            this.transform.Rotate(new Vector3(0, rotation_ ,0) * Time.deltaTime);
        }
    }
}
