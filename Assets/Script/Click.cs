using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField]
    private GameObject TitleSet;
    [SerializeField]
    private GameObject StageSelectSet;
    [SerializeField]
    private GameObject AppleDrawSet;
    [SerializeField]
    private GameObject BananaDrawSet;
    [SerializeField]
    private bool isClick;
    [SerializeField]
    private GameObject AppleBackButton;
    [SerializeField]
    private GameObject BananaBackButton;
    [SerializeField]
    private GameObject DestroyCollider;
    void Start()
    {
        isClick = true;
    }

    void Update()
    {
        if(isClick && Input.anyKeyDown)
        {
            isClick = false;
            TitleSet.SetActive(false);
            StageSelectSet.SetActive(true);
        }
        
    }

    public void Draw01()
    {
        StageSelectSet.SetActive(false);
        AppleBackButton.SetActive(true);
        BananaBackButton.SetActive(true);
        AppleDrawSet.SetActive(true);
        AppleDrawSet.GetComponent<Draw>().isOn = true;
    }
    
    public void BackToSelect()
    {
        StartCoroutine(DestroyOnOff());
        BananaDrawSet.SetActive(false);
        StageSelectSet.SetActive(true);
        AppleDrawSet.SetActive(false);
        AppleDrawSet.GetComponent<Draw>().isOn = false;
        BananaDrawSet.GetComponent<Draw>().isOn = false;
        AppleBackButton.SetActive(false);
    }

    public void NextToBanana()
    {
        StartCoroutine(DestroyOnOff());
        AppleDrawSet.SetActive(false);
        BananaDrawSet.SetActive(true);
        BananaDrawSet.GetComponent<Draw>().isOn = true;
        BananaBackButton.SetActive(false);
    }

    public IEnumerator DestroyOnOff()
    {
        DestroyCollider.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        DestroyCollider.SetActive(false);
    }
}
