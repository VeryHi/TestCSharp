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
        new Character(EName.DORA,"도라에몽")
        ,
        new Character(eName: EName.JIN_GOO, myName: "진구")
        {
            age = 15
        },
        new Character(EName.B_SIL, "비실이")
        {
            eName = EName.B_SIL,
            myName = "비실이"
        },
        new Character(EName.DORA, "")
        {
            eName = EName.DORA2,
            myName = "도라야끼",
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
        Debug.Log($"나의 이름은 {myName}(이)다. 스테이트는 {eName}(이)다.");
    }
}
