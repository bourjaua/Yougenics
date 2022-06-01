using System.Collections;
using System.Collections.Generic;
using NodeCanvas.BehaviourTrees;
using UnityEngine;

namespace Kevin
{
    public class TestScript : MonoBehaviour
    {
        public float distance;

        public GameObject playerOne;

        public GameObject playerTwo;
        void Update()
        {
            distance = Vector3.Distance(playerOne.transform.position, playerTwo.transform.position);
            
        }

        public void ScaleUp()
        {
            gameObject.transform.localScale = new Vector3(5f, 5f, 5f);
        }

        public void ScaleDown()
        {
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}

