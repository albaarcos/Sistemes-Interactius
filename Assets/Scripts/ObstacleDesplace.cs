using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotation : MonoBehaviour
{
    private bool movingLeft;

    void Start() {
        movingLeft = true;
    }
    void Update() {
        if (movingLeft == true) {
            // move left
            transform.Translate(new Vector3(-3, 0, 0) * Time.deltaTime);
            if (transform.position.x <= -4) movingLeft = false;
        } else {
            // move right
            transform.Translate(new Vector3(3, 0, 0) * Time.deltaTime);
            if (transform.position.x >= 4) movingLeft = true;
        }
    }
}
