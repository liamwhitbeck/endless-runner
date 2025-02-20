using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (Input.GetKey(KeyCode.LeftArrow)) 
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
        if (Input.GetKey(KeyCode.RightArrow))
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
    }
}
