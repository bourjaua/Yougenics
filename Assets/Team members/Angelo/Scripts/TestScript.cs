using System.Collections;
using System.Collections.Generic;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Test()
    {
        Debug.Log("This is text");
    }

    public bool TrueFunc()
    {
        return true;
    }

    public string StringTest(string input)
    {
        return ("You wrote down: " + input);
    }

    public void PrintThis(string input)
    {
        Debug.Log(input);
    }
}
