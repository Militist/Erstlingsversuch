using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LernProject 
{
    public class Shield : MonoBehaviour
    {
        [SerializeField] private float _durability = 10f;
        public void Init(float durability)
        {
            _durability = durability;
            Destroy(gameObject, 3);
        }

        public void Update()
        {

        }
    }
}



