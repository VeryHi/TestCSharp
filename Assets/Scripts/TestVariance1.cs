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
        //funcVariance = TestVarianceMethod; // �ݰ������� �ڱ��ڽ�,�������̽�, �θ�Ŭ����,�θ��������̽� ������ȯ�� ����
        funcContravariance2 = TestContravarianceMethod2;

        funcContravariance = funcVariance;
        //funcVariance = funcContravariance; // �ݰ�����

    }

    int TestContravarianceMethod(object obj)
    {
        Debug.Log($"�ݰ������׽�Ʈ");
        return 0;
    }

    int TestVarianceMethod(string str)
    {
        Debug.Log($"�������׽�Ʈ");
        return 0;
    }

    string TestContravarianceMethod2(object obj)
    {
        Debug.Log($"�ݰ������׽�Ʈ");
        return null;
    }
}
