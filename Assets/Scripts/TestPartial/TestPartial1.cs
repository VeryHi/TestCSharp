using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class TestPartial1 : MonoBehaviour
{
    int a = 5;
    int b = 3;

    int c;

    string book = "apple";
    string my = "your";
    
    // Start is called before the first frame update
    void Start()
    {
        Method3();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Method1()
    {
        Debug.Log("È£·Î·Î·Î·Î·Î·Î·Î·Î·Î ¾Æ°¼°¼°¼°¼ ¿ì°¼°¼°½");
        Debug.Log("È£·Î·Î·Î¤±¤¤¤·;¤Ó¸¸¤·;¤±´Ï¤¿¤·;¤¤¤±¤·¿ì°¼°¼°½");
        Debug.Log("È£·Î·Î·Î¤±¤¤;¤·¤±´Ï¾Ï;¤¤¤·°¼°½");
        Debug.Log("È£·Î·Î·Î·Î¤±¤¤¾È¤±¤· ¿ì°¼°¼°½");
    }

    void Method2()
    {
        Debug.Log("³ª´Â ¸Þ¼Òµå2");
        Method1();

    }

    partial void Method3();
}

public class Wallet 
{
    public Wallet(string walletMaterial, string brand, int money)
    {
        this.walletMaterial = walletMaterial;
        this.brand = brand;
        this.money = money;
    }

    public string walletMaterial;
    public string brand;
    public int money;


    public void GetInformation()
    {
        Debug.Log($"³» Áö°©ÀÇ ÀçÁúÀº {walletMaterial}ÀÌ°í, ºê·£µå´Â {brand}(ÀÌ)´Ù. µ·Àº {money}¿øÀÌ µé¾îÀÖ´Ù.");
    }
}