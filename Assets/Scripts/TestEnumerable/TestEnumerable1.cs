using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnumerable1 : MonoBehaviour
{

    IEnumerable<int> Fibonacci()
    {
        int current = 0;
        int next = 1;

        try
        {
            while (true)
            {
                yield return current;
                int oldCurrent = current;
                current = next;
                next = next + oldCurrent;
            }
        }
        finally
        {
            Debug.Log("Finally");
        }
    }

    IEnumerable<string> Iterator()
    {
        try
        {
            Debug.Log("Before first yield");
            yield return "first";
            Debug.Log("Between yields");
            yield return "second";
            Debug.Log("After second yield");
        }
        finally
        {
            Debug.Log("In finally block");
        }
    }



    void Start()
    {
        //foreach (var item in Iterator())
        //{
        //    Debug.Log($"value:{item}");
        //    if(item != null)
        //    {
        //        break;
        //    }
        //}
        enumerable = Fibonacci();
        coroutineUpdate = CoroutineUpdate();
        StartCoroutine(coroutineUpdate);
    }

    bool isOn = true;

    IEnumerable<int> enumerable;

    IEnumerator coroutineUpdate;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            StopCoroutine(coroutineUpdate);
        }


        if (Input.GetKeyDown(KeyCode.U))
        {
            StartCoroutine(coroutineUpdate);
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Debug.Log("府悸");
            enumerator.Dispose();
        }

    }
    IEnumerator<int> enumerator;
    IEnumerator CoroutineUpdate()
    {

        //using (IEnumerator<int> enumerator = enumerable.GetEnumerator())
        //{
        //    while (enumerator.MoveNext())
        //    {
        //        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));

        //        if (enumerator.Current > 1000)
        //        {
        //            yield break;
        //        }

        //        int value = enumerator.Current;
        //        Debug.Log($"Received value: {value}");

        //        yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.Space));
        //    }
        //}

        using (enumerator = enumerable.GetEnumerator())
        {
            while (true)
            {
                enumerator.MoveNext();
                yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));

                if (enumerator.Current > 100)
                {
                    //enumerator.Dispose();
                    yield break;
                }

                int value = enumerator.Current;
                Debug.Log($"Received value: {value}");

                yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.Space));
            }

        }

        Debug.Log("内风凭 场");

    }



}