using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myGame
{
    // needed requirements
    //[RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Animator))]
    //[RequireComponent(typeof(CapsuleCollider))]
    //  using charatercontroller already has capsuleCollider
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMoveController : MonoBehaviour
    {
        //public Rigidbody gcRigidbody;
        public CharacterController gcController;

        // player move
        Vector2 playerMoveDirection;
        private Vector3 vRealMoveDirection;
        public float playerMoveSpeed = 1.0f;

        // handle with player Jump
        bool isOnground = true;
        public float fJumpForce = 20.0f;
        public float fGravityScale = 1.0f;

  
        // player move's direction always is the camera's direction
        public Transform gcCamera;

        // animation of player
        public Animator gcPlayerAnimator;

        void Start()
        {
            //gcRigidbody = GetComponent<Rigidbody>();
            gcController = GetComponent<CharacterController>();
            gcPlayerAnimator = GetComponent<Animator>();

        }

        void Update()
        {
           // player move
            playerMoveDirection = InputController.leftSticker;
            move();

            if (InputController.ifAttack)
            {
                StartCoroutine(PlayerAttackEnable());
            }

            if (InputController.ifJump)
            {
                PlayerJump();
            }

        }

        void FixedUpdate()
        {
            isOnground = gcController.isGrounded;

            vRealMoveDirection.y += Physics.gravity.y * Time.deltaTime * fGravityScale;

        }

        private void move()
        {
            // player should rotate at y-axis (Notice: if cancel, fRotateAngleY would be 0)
            if (playerMoveDirection != Vector2.zero)
            {
                float fRotateAngleY = Mathf.Atan2(playerMoveDirection.x, playerMoveDirection.y) * Mathf.Rad2Deg + gcCamera.eulerAngles.y;
                //float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, fRotateAngleY, ref turnSmoothVelocity, turnSmoothTime);
                // the rotation would change the transform.forward
                transform.rotation = Quaternion.Euler(0.0f, fRotateAngleY, 0.0f);
            }

            //vRealMoveDirection = new Vector3(playerMoveDirection.x, vRealMoveDirection.y, playerMoveDirection.y);
            // make player always move towards camera's
            float yStore = vRealMoveDirection.y;
            vRealMoveDirection = gcCamera.forward * playerMoveDirection.y + gcCamera.right * playerMoveDirection.x;
            vRealMoveDirection.y = yStore;

            gcController.Move(vRealMoveDirection * playerMoveSpeed * Time.deltaTime);

            // set animator value
            gcPlayerAnimator.SetBool("isOnGround", isOnground);

            float checkSpeed = (Mathf.Abs(playerMoveDirection.x) + Mathf.Abs(playerMoveDirection.y)) / 2;

            gcPlayerAnimator.SetFloat("Speed", checkSpeed);
        }

        private void PlayerJump()
        {
            if (isOnground)
            {
                vRealMoveDirection.y = fJumpForce;
                //gcRigidbody.velocity = new Vector3(gcRigidbody.velocity.x, fJumpForce, gcRigidbody.velocity.z);
            }
        }

        IEnumerator PlayerAttackEnable()
        {
            InputController.currentStatus = Constants.GameStatus.PlayerAttack;
            gcPlayerAnimator.Play("arthur_attack_01");          
            // wait for attack animation stop
            float duration = gcPlayerAnimator.GetCurrentAnimatorStateInfo(0).length;
            yield return new WaitForSeconds(duration);
            InputController.currentStatus = Constants.GameStatus.Normal;
        }
        
      
    }
}

