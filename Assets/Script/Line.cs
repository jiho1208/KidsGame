using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    Camera cam;
    LineRenderer lir;
    Vector3 MousePosition;

    void Start()
    {
        lir = GetComponent<LineRenderer>();
        cam = FindObjectOfType<Camera>();
    }

    void Update()
    {
        MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePosition.z = 0;
        lir.SetPosition(1, MousePosition);
    }
}
