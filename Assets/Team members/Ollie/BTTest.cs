using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ollie
{
    public class BTTest : MonoBehaviour
    {
        public float distance;
        public Transform target;

        void Update()
        {
            distance = Vector3.Distance(this.transform.position, target.position);
        }
    }
}