using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Object
{
    public class Weapon : MonoBehaviour
    {
        public float DamageAmount;

        private void OnTriggerEnter(Collider other)
        {
            if (myGame.InputController.ifAttack && other.tag == "Enemy")
            {
                // player is attack enemy
                //Debug.Log("player is attacking enemy");

                // change enemy HP
                other.gameObject.GetComponent<Character.Enemy>().ChangeHP(-DamageAmount);
            }

            if (myGame.InputController.ifAttack && other.name == "Boss")
            {
                // player is attack enemy
                //Debug.Log("player is attacking enemy");

                // change enemy HP
                other.gameObject.GetComponent<BossAI.Boss>().ChangeHP(-DamageAmount);
            }

        }
    }
}

