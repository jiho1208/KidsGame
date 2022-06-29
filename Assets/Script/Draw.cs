using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    public bool isOn;
    [SerializeField]
    private GameObject brush;
    [SerializeField]
    private Camera cam;
    private Vector2 mousepos;
    float time = 0;
    void Start()
    {
    }

    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetMouseButton(0) && time >= 0.01 && isOn)
        {
            time = 0;
            mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(brush, mousepos, Quaternion.identity);
        }
    }
}
