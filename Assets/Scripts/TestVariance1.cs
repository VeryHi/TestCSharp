using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVariance1 : MonoBehaviour
{
    Func<string, int> funcContravariance;
    Func<object, int> funcVariance;
    Func<object, IConvertible> funcContravariance2;

    void Start()
    {
        funcContravariance = TestContravarianceMethod;
        //funcVariance = TestVarianceMethod; // 반공변성은 자기자신,인터페이스, 부모클래스,부모인터페이스 참조변환만 가능
        funcContravariance2 = TestContravarianceMethod2;

        funcContravariance = funcVariance;
        //funcVariance = funcContravariance; // 반공변성

    }

    int TestContravarianceMethod(object obj)
    {
        Debug.Log($"반공변성테스트");
        return 0;
    }

    int TestVarianceMethod(string str)
    {
        Debug.Log($"공변성테스트");
        return 0;
    }

    string TestContravarianceMethod2(object obj)
    {
        Debug.Log($"반공변성테스트");
        return null;
    }
}
