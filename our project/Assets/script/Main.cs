using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

        public Transform dragonTransform;
        Vector3 range;
        void Awake()
        {
            range = transform.position - dragonTransform.position;
        }
        void FixedUpdate()
        {
            transform.position = new Vector3(range.x + dragonTransform.position.x, transform.position.y, range.z + dragonTransform.position.z);
        }
    }

