using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace LernProject
{
    public class SpawnEnemy : MonoBehaviour
    {
        public GameObject enemyPrefab;
        public Transform spawnPosition;
        public float spawnTime = 3;
        public float t = 0;
        public int countEnemy = 5;
        void Start()
        {
            
        }

        private void Update()
        {
            SpawnEnemys();
        }

        public void SpawnEnemys()
        {
            t = t + Time.deltaTime;
            if ((t >= spawnTime) && (countEnemy > 0))
            {
                var enemyObj = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                countEnemy--;
                t = 0;
            }
        }
    }
}

