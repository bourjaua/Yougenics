using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ollie
{
    public class CritterAI : MonoBehaviour
    {
        public float health;
        public float maxHealth;
        
        public Vector3 myPos;
        public Vector3 targetPos;
        public float mySpeed;

        public List<GameObject> npcTargets;

        private void Start()
        {
            health = maxHealth;
            npcTargets = new List<GameObject>();
        }

        private void Update()
        {
            myPos = transform.position;
            Vector3.MoveTowards(myPos, targetPos, mySpeed);
        }
    }
}
