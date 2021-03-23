using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Character
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Animator))]
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private float fTotalHP = 5;
        private float fCurrentHP;

        public Animator gcEnemyAnimator;

        // get health bar
        public GameObject healthBarUI;
        public Slider healthSlide;

        private void Start()
        {
            fCurrentHP = fTotalHP;
            gcEnemyAnimator = GetComponent<Animator>();

            // set healthBarUI false
            healthBarUI.SetActive(false);  
        }

        public void ChangeHP(float changeValue)
        {
            fCurrentHP += changeValue;
        }

        private void Update()
        {

            // update slider value
            healthSlide.value = 1 - fCurrentHP / fTotalHP;

            // only enemy is under attacking, show the health bar
            if (fCurrentHP < fTotalHP)
            {
                healthBarUI.SetActive(true);
            }

            if (fCurrentHP <= 0)
            {
                StartCoroutine(EnemyDie());
            }            

        }

        public IEnumerator EnemyDie()
        {
            // player die animation
            gcEnemyAnimator.Play("die");

            // length is duration and normalized time is running time in normalized format
            float duration = gcEnemyAnimator.GetCurrentAnimatorStateInfo(0).length;
            yield return new WaitForSeconds(duration);

            Destroy(gameObject);
        }
    }

}
