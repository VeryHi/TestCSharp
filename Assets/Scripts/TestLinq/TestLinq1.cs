using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class TestLinq1 : MonoBehaviour
{
    public enum EName
    {
       DORA,
       DORA2,
       JIN_GOO,
       B_SIL
    }

    Character[] characters = new Character[]
    {
        new Character(EName.DORA,"���󿡸�")
        ,
        new Character(eName: EName.JIN_GOO, myName: "����")
        {
            age = 15
        },
        new Character(EName.B_SIL, "�����")
        {
            eName = EName.B_SIL,
            myName = "�����"
        },
        new Character(EName.DORA, "")
        {
            eName = EName.DORA2,
            myName = "����߳�",
            age = 300
        }
    };

    Dictionary<EName, Character> stateDic;
    private void Start()
    {
        stateDic = characters.Where(c => c.age > 0).ToDictionary(c => c.eName);

        var stateDic2 = characters
            .Where(c => c.age > 150 || c.eName == EName.B_SIL)
            .ToDictionary(c => c.eName);

        var character = stateDic2.Values.Select(c => new { c.age, c.eName });
        
        foreach (var item in character)
        {
            Debug.Log(item.eName);
            Debug.Log(item.age);
        }
    }
}

public class Character 
{
    public Character(TestLinq1.EName eName, string myName)
    {
        this.eName = eName;
        this.myName = myName;
    }
    public TestLinq1.EName eName;
    public string myName;
    public int age;
    public void GetInfo()
    {
        Debug.Log($"���� �̸��� {myName}(��)��. ������Ʈ�� {eName}(��)��.");
    }
}
