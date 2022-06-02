using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float Hp;

    // Start is called before the first frame update
    void Start()
    {
        HPO();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HPO()
    {
        if(Input.GetKeyDown(KeyCode.R))
        { 
            Hp += 10;
            Debug.Log(Hp);
        }
    }
    
    
}
