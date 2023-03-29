using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncScript : MonoBehaviour
{
    private async Task Start()
    {
        print("its async, wait a sec");
        await WriteText();
    }
    

    private async Task WriteText()
    {
        var text = await System.IO.File.ReadAllTextAsync(@"Assets/example.txt");
        await Task.Delay(100);
        print(text);
    }
}
