using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myAI
{
    public class EnemyAI : MonoBehaviour
    {
        [SerializeField] private float totalHealth;

        // the threshold that is regarded as lowHealth
        [SerializeField] private float lowHealth;

        // if the enemy can heal it self
        [SerializeField] private float healRate = 0;

        // attack player range and chase player range
        [SerializeField] private float attackRange;
        [SerializeField] private float chaseRange;

        // the player
        [SerializeField] private Transform playerTransform;

        private float currentHealth
        {
            get { return currentHealth;}
            // currentHealth is between the range(0, totalHealth)
            set { currentHealth = Mathf.Clamp(value, 0, totalHealth);}
        }

        private void Start()
        {
            currentHealth = totalHealth;
        }

        public float GetCurrentHealth()
        {
            return currentHealth;
        }

        private void Update()
        {
            // assuming that enemy continue to heal itself
            // TODO: add enemy healNode, make enemy heal itself under some conditions 
            currentHealth += Time.deltaTime * healRate;
        }
    }
}

