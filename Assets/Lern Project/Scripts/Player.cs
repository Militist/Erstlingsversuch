using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LernProject
{
    public class Player : MonoBehaviour
    {
        public GameObject shieldPrefab;
        public Transform spawnPosition;
        private bool _isSpawnShield;
        private int level = 1;
        private bool _isSprint;

        private Vector3 _direction;
        public float speed = 2f;
        public float speedRotate = 20f;

        void Start()
        {

        }


        void Update()
        {
            if (Input.GetMouseButtonDown(1))
                _isSpawnShield = true;

            _direction.x = (Input.GetAxis("Horizontal"));
            _direction.z = (Input.GetAxis("Vertical"));

            _isSprint = Input.GetButton("Sprint");
        }

        private void FixedUpdate()
        {
            if (_isSpawnShield)
            {
                _isSpawnShield = false;
                SpawnShield();
            }

            Move(Time.fixedDeltaTime);

            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * speedRotate * Time.fixedDeltaTime, 0));
        }

        private void SpawnShield()
        {
            var shieldObj = Instantiate(shieldPrefab, spawnPosition.position, spawnPosition.rotation);
            var shield = shieldObj.GetComponent<Shield>();
            shield.Init(10 * level);
            shieldObj.transform.SetParent(spawnPosition);       
        }
       
        private void Move(float delta)
        {
            var fixedDirection = transform.TransformDirection(_direction.normalized);
            transform.position += fixedDirection * (_isSprint ? speed * 2 : speed) * delta;
        }
    }
}
