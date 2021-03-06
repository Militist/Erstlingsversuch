using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace LernProject
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] GameObject _bulletPrefab;
        [SerializeField] Transform _spawnPosition;
       
        void Start()
        {
            _player = FindObjectOfType<Player>();
        }

        void Update()
        {
            if(Vector3.Distance(transform.position, _player.transform.position) < 6)
            {
                if (Input.GetMouseButtonDown(0)) 
                Fire();
            }
        }

        private void Fire()
        {
            var shieldObj = Instantiate(_bulletPrefab, _spawnPosition.position, _spawnPosition.rotation);
            var shield = shieldObj.GetComponent<Bullet>();
            shield.Init(_player.transform, 10, 0.2f);
        }
    }
}

