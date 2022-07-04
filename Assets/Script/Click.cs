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
    private GameObject CatDrawSet;
    [SerializeField]
    private GameObject DogDrawSet;
    private bool isClick;
    [SerializeField]
    private GameObject Setting;
    [SerializeField]
    private GameObject SettingButton;
    [SerializeField]
    private GameObject AppleBackButton;
    [SerializeField]
    private GameObject BananaBackButton;
    [SerializeField]
    private GameObject CatBackButton;
    [SerializeField]
    private GameObject DogBackButton;
    [SerializeField]
    private GameObject DestroyCollider;
    [SerializeField]
    private GameObject NumberCardSet;
    [SerializeField]
    private GameObject NumberCardUI;
    [SerializeField]
    private GameObject ShapesCardSet;
    [SerializeField]
    private GameObject ShapesCardUI;
    [SerializeField]
    private GameObject ColorsCardSet;
    [SerializeField]
    private GameObject ColorsCardUI;
    [SerializeField]
    private GameObject ConsonantCardSet;
    [SerializeField]
    private GameObject ConsonantCardUI;
    [SerializeField]
    private GameObject Credit;
    [SerializeField]
    private GameObject[] AllCardSet;
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
        SettingButton.SetActive(true);
        StageSelectSet.SetActive(false);
        AppleBackButton.SetActive(true);
        BananaBackButton.SetActive(true);
        AppleDrawSet.SetActive(true);
        AppleDrawSet.GetComponent<Draw>().isOn = true;
    }
    
    public void BackToSelect()
    {
        StartCoroutine(DestroyOnOff());
        SettingButton.SetActive(false);
        AppleDrawSet.SetActive(false);
        BananaDrawSet.SetActive(false);
        CatDrawSet.SetActive(false);
        DogDrawSet.SetActive(false);
        StageSelectSet.SetActive(true);
        AppleDrawSet.GetComponent<Draw>().isOn = false;
        BananaDrawSet.GetComponent<Draw>().isOn = false;
        CatDrawSet.GetComponent<Draw>().isOn = false;
        DogDrawSet.GetComponent<Draw>().isOn = false;
        AppleBackButton.SetActive(false);
    }

    public void NextToBanana()
    {
        StartCoroutine(DestroyOnOff());
        AppleDrawSet.SetActive(false);
        BananaDrawSet.SetActive(true);
        BananaDrawSet.GetComponent<Draw>().isOn = true;
        CatBackButton.SetActive(true);
        BananaBackButton.SetActive(false);
    }
    public void NextToCat()
    {
        StartCoroutine(DestroyOnOff());
        BananaDrawSet.SetActive(false);
        CatDrawSet.SetActive(true);
        CatDrawSet.GetComponent<Draw>().isOn = true;
        DogBackButton.SetActive(true);
        CatBackButton.SetActive(false);
    }
    public void NextToDog()
    {
        StartCoroutine(DestroyOnOff());
        CatDrawSet.SetActive(false);
        DogDrawSet.SetActive(true);
        DogDrawSet.GetComponent<Draw>().isOn = true;
        DogBackButton.SetActive(false);
    }

    public IEnumerator DestroyOnOff()
    {
        DestroyCollider.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        DestroyCollider.SetActive(false);
    }

    public void CardSelect()
    {
        SettingButton.SetActive(true);
        NumberCardSet.SetActive(true);
        NumberCardUI.SetActive(true);
        ShapesCardUI.SetActive(true);
        StageSelectSet.SetActive(false);
    }

    public void CardBackSelect()
    {
        SettingButton.SetActive(false);
        NumberCardUI.SetActive(false);
        NumberCardSet.SetActive(false);
        ShapesCardSet.SetActive(false);
        ShapesCardUI.SetActive(false);
        ColorsCardSet.SetActive(false);
        ColorsCardUI.SetActive(false);
        ConsonantCardSet.SetActive(false);
        ConsonantCardUI.SetActive(false);
        StageSelectSet.SetActive(true);
        foreach(var Card in AllCardSet)
        {
            Card.GetComponent<BoxCollider2D>().enabled = true;
            Card.GetComponent<SpriteRenderer>().sprite = GetComponent<Card>().image[0];
        }
    }

    public void NumberNextShapes()
    {
        NumberCardSet.SetActive(false);
        ShapesCardSet.SetActive(true);
        ShapesCardUI.SetActive(false);
        ColorsCardUI.SetActive(true);
        foreach (var Card in AllCardSet)
        {
            Card.GetComponent<BoxCollider2D>().enabled = true;
            Card.GetComponent<SpriteRenderer>().sprite = GetComponent<Card>().image[0];
        }
    }

    public void ShapesNextColors()
    {
        ShapesCardSet.SetActive(false);
        ColorsCardSet.SetActive(true);
        ColorsCardUI.SetActive(false);
        ConsonantCardUI.SetActive(true);
        foreach (var Card in AllCardSet)
        {
            Card.GetComponent<BoxCollider2D>().enabled = true;
            Card.GetComponent<SpriteRenderer>().sprite = GetComponent<Card>().image[0];
        }
    }

    public void ColorsNextConsonant()
    {
        ColorsCardSet.SetActive(false);
        ConsonantCardSet.SetActive(true);
        ConsonantCardUI.SetActive(false);
        foreach (var Card in AllCardSet)
        {
            Card.GetComponent<BoxCollider2D>().enabled = true;
            Card.GetComponent<SpriteRenderer>().sprite = GetComponent<Card>().image[0];
        }
    }
    
    public void SettingButtonClick()
    {
        Setting.SetActive(true);
        SettingButton.SetActive(false);
        AppleDrawSet.GetComponent<Draw>().isOn = false;
        BananaDrawSet.GetComponent<Draw>().isOn = false;
        CatDrawSet.GetComponent<Draw>().isOn = false;
        DogDrawSet.GetComponent<Draw>().isOn = false;
    }

    public void CheckButtonClick()
    {
        Setting.SetActive(false);
        SettingButton.SetActive(true);
        AppleDrawSet.GetComponent<Draw>().isOn = true;
        BananaDrawSet.GetComponent<Draw>().isOn = true;
        CatDrawSet.GetComponent<Draw>().isOn = true;
        DogDrawSet.GetComponent<Draw>().isOn = true;
    }

    public void CreditButtonClick()
    {
        Credit.SetActive(true);

    }

    public void CloseButtonClick()
    {
        Credit.SetActive(false);
    }
}



