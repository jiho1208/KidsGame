using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    string firstCard;
    string secondCard;
    bool click = false;
    bool change = false;
    GameObject hit1;
    GameObject hit2;
    public Sprite[] image;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 1000);

            if (hit.collider.tag == "Card" && change == false)
            {
                if (click == false)
                {
                    click = true;
                    hit1 = hit.collider.gameObject;
                    firstCard = hit.collider.name;
                    hit.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    switch (firstCard)
                    {
                        case "one":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[1];
                            break;
                        case "two":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[2];
                            break;
                        case "three":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[3];
                            break;
                        case "four":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[4];
                            break;
                        case "Circle":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[5];
                            break;
                        case "Square":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[6];
                            break;
                        case "Triangle":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[7];
                            break;
                        case "Star":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[8];
                            break;
                        case "Red":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[9];
                            break;
                        case "Yellow":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[10];
                            break;
                        case "Green":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[11];
                            break;
                        case "Blue":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[12];
                            break;
                        case "ㄱ":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[13];
                            break;
                        case "ㄴ":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[14];
                            break;
                        case "ㄷ":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[15];
                            break;
                        case "ㄹ":
                            hit1.GetComponent<SpriteRenderer>().sprite = image[16];
                            break;
                    }
                }
                else
                {
                    click = false;
                    hit2 = hit.collider.gameObject;
                    secondCard = hit.collider.name;
                    hit.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    if (firstCard == secondCard)
                    {
                        Debug.Log("맞는듯");
                        switch (secondCard)
                        {
                            case "one":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[1];
                                break;
                            case "two":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[2];
                                break;
                            case "three":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[3];
                                break;
                            case "four":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[4];
                                break;
                            case "Circle":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[5];
                                break;
                            case "Square":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[6];
                                break;
                            case "Triangle":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[7];
                                break;
                            case "Star":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[8];
                                break;
                            case "Red":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[9];
                                break;
                            case "Yellow":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[10];
                                break;
                            case "Green":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[11];
                                break;
                            case "Blue":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[12];
                                break;
                            case "ㄱ":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[13];
                                break;
                            case "ㄴ":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[14];
                                break;
                            case "ㄷ":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[15];
                                break;
                            case "ㄹ":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[16];
                                break;
                        }
                    }
                    else
                    {
                        Debug.Log("아닌듯");
                        switch (secondCard)
                        {
                            case "one":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[1];
                                break;
                            case "two":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[2];
                                break;
                            case "three":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[3];
                                break;
                            case "four":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[4];
                                break;
                            case "Circle":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[5];
                                break;
                            case "Square":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[6];
                                break;
                            case "Triangle":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[7];
                                break;
                            case "Star":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[8];
                                break;
                            case "Red":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[9];
                                break;
                            case "Yellow":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[10];
                                break;
                            case "Green":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[11];
                                break;
                            case "Blue":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[12];
                                break;
                            case "ㄱ":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[13];
                                break;
                            case "ㄴ":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[14];
                                break;
                            case "ㄷ":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[15];
                                break;
                            case "ㄹ":
                                hit2.GetComponent<SpriteRenderer>().sprite = image[16];
                                break;
                        }
                        StartCoroutine(CardCheck());
                    }
                }
            }

        }
    }

    IEnumerator CardCheck()
    {
        change = true;
        yield return new WaitForSeconds(1f);
        hit1.GetComponent<BoxCollider2D>().enabled = true;
        hit1.GetComponent<SpriteRenderer>().sprite = image[0];
        hit2.GetComponent<BoxCollider2D>().enabled = true;
        hit2.GetComponent<SpriteRenderer>().sprite = image[0];
        change = false;
    }
}
