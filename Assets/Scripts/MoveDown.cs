using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (index == 0)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        } else if (index == 1)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        } else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
