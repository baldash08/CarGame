using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector2 startPosition;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.y + 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < startPosition.y - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
