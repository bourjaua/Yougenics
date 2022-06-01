using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LukePlayer : MonoBehaviour
{
    public Transform target;
    public float distance;
    public float threshold = 15f;

    public bool CheckDistance(float amount)
    {
        return amount < threshold;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Magnitude(target.position - transform.position);
    }
}
