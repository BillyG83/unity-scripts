using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start() {
        // saving the position of background at start
        startPos = transform.position;
        // BoxCollider added in UI, this get half background width
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update() {
        // background moves left on x axis so check when its moved 50
        if(transform.position.x < startPos.x - repeatWidth) {
            transform.position = startPos;
        }
    }
}
