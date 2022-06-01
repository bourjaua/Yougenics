using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ollie
{
    public class CritterTrigger : MonoBehaviour
    {
        public CritterAI parent;

        private void Start()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            print("hello");
            iNPC iNPC = other.gameObject.GetComponent<iNPC>();
            if (iNPC != null)
            {
                //figure out how to raycast @ other
                parent.npcTargets.Add(other.gameObject);
            }
        }

        // private void OnTriggerExit(Collider other)
        // {
        //     iNPC iNPC = other.gameObject.GetComponent<iNPC>();
        //     if (iNPC != null)
        //     {
        //         //figure out how to raycast @ other
        //         parent.npcTargets.Remove(other.gameObject);
        //     }
        // }
    }
}
