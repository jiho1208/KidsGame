using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField]
    private float speed;
    Vector3 mousepos;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(Physics.Raycast(mousepos, Vector3.forward))
            {
                RaycastHit2D Hitobject = Physics2D.Raycast(mousepos, Vector3.forward);
                if(Hitobject.collider.tag == "Card")
                {
                    Hitobject.collider.gameObject.GetComponent<Animator>().SetBool("isClick", true);
                }
            }
            
        }
    }

    public void Click()
    {
        transform.rotation = new Quaternion(0f, Time.deltaTime * speed, 0f, 0f);
    }
}
