using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace LernProject
{
    public class GiveLife : MonoBehaviour
    {
        [SerializeField] private Player _player;

        void Start()
        {
            _player = FindObjectOfType<Player>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
                Destroy(gameObject);
        }
    }
}

