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
        Debug.Log("硲稽稽稽稽稽稽稽稽稽 焼絢絢絢絢 酔絢絢綾");
        Debug.Log("硲稽稽稽けいし;び幻し;け艦たし;いけし酔絢絢綾");
        Debug.Log("硲稽稽稽けい;しけ艦章;いし絢綾");
        Debug.Log("硲稽稽稽稽けい照けし 酔絢絢綾");
    }

    void Method2()
    {
        Debug.Log("蟹澗 五社球2");
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
        Debug.Log($"鎧 走逢税 仙霜精 {walletMaterial}戚壱, 崎沓球澗 {brand}(戚)陥. 儀精 {money}据戚 級嬢赤陥.");
    }
}