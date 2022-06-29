using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleUI : MonoBehaviour
{
    [SerializeField]
    private float speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(0, Mathf.Sin(Time.time)) * speed;
    }
}
