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
        Debug.Log("ȣ�ηηηηηηηη� �ư������� �찼����");
        Debug.Log("ȣ�ηηΤ�����;�Ӹ���;���Ϥ���;�������찼����");
        Debug.Log("ȣ�ηηΤ���;�����Ͼ�;��������");
        Debug.Log("ȣ�ηηηΤ����Ȥ��� �찼����");
    }

    void Method2()
    {
        Debug.Log("���� �޼ҵ�2");
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
        Debug.Log($"�� ������ ������ {walletMaterial}�̰�, �귣��� {brand}(��)��. ���� {money}���� ����ִ�.");
    }
}