using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    [SerializeField]
    private float speed;
    Vector3 pos = new Vector2(-22, 0);
    void Start()
    {
    }

    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        if(transform.position.x >= 22)
        {
            transform.position = pos;
        }
    }
}
