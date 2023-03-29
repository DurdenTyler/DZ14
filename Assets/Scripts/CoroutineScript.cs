using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineScript : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(WriteText());
    }


    private IEnumerator WriteText()
    {
        var text = System.IO.File.ReadAllText(@"Assets/example.txt");
        print("its coroutine, wait a sec...");
        yield return new WaitForSeconds(1f);
        print(text);
    }

}
