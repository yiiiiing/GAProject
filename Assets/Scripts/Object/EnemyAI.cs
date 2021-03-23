using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character
{
    public class EnemyAI : MonoBehaviour
    {
        public Transform thePlayer;
        public float turnSpeed;
        public float moveSpeed;
        public float jumpSpeed;

        // raycast
        public float targetDistance;
        public float allowedDistance;

        public RaycastHit hit;

        // get animation
        private Animator anim;

        private Rigidbody rigid;


        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
            rigid = GetComponent<Rigidbody>();

        }

        // Update is called once per frame
        void Update()
        {
            // check if ray hits the player
            Vector3 rayDirection = thePlayer.position - transform.position;
            if (Physics.Raycast(transform.position, rayDirection, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Player"))
                {
                    targetDistance = hit.distance;

                    // draw the ray
                    //Debug.DrawRay(transform.position, rayDirection*1000, Color.yellow);

                    if (targetDistance < allowedDistance)
                    {

                        anim.Play("walk");
                        myTransform.MoveTowards.Move(thePlayer, this.transform, moveSpeed, turnSpeed);

                    }
                    else
                    {
                        anim.Play("idle");
                    }
                }


            }
        }
    }
}

