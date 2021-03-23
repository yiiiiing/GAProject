using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace myGame
{

    public class InputController : MonoBehaviour
    {
        InputActions controls;

        // public values (get only)
        public static Vector2 leftSticker { get; private set; }
        public static Vector2 rightSticker { get; private set; }

        public static bool ifJump { get; private set;}
        public static bool ifPick { get; private set; }
        public static bool ifMedicine { get; private set; }
        public static bool ifMenu { get; private set; }
        public static bool ifAttack { get; private set; }

        public static bool ifEnter { get; private set; }


        private Constants.GameStatus lastStatus;
        public static Constants.GameStatus currentStatus;

        private void Awake()
        {

            controls = new InputActions();
        
            controls.GamePlay.PlayerMove.performed += ctx => leftSticker = ctx.ReadValue<Vector2>();
            controls.GamePlay.PlayerMove.canceled += ctx => leftSticker = Vector2.zero; ;

            controls.GamePlay.CameraMove.performed += ctx => rightSticker = ctx.ReadValue<Vector2>();
            controls.GamePlay.CameraMove.canceled += ctx => rightSticker = Vector2.zero; ;

            controls.GamePlay.Jump.performed += ctx => ifJump = true;
            controls.GamePlay.Jump.canceled += ctx => ifJump = false;

            controls.GamePlay.PickUp.performed += ctx => ifPick = true;
            controls.GamePlay.PickUp.canceled += ctx => ifPick = false;

            controls.GamePlay.Medicine.performed += ctx => ifMedicine = true;
            controls.GamePlay.Medicine.canceled += ctx => ifMedicine = false;

            controls.GamePlay.Attack.performed += ctx => ifAttack = true;
            controls.GamePlay.Attack.canceled += ctx => ifAttack = false;

            //controls.GamePlay.Menu.performed += ctx => ifMenu = true;
            //controls.GameUI.Menu.performed += ctx => ifMenu = false;

            controls.GamePlay.Enter.performed += ctx => ifEnter = true;
            controls.GamePlay.Enter.canceled += ctx => ifEnter = false;

            //controls.GameUI.OK.performed += ctx => ifOK = true;
            //controls.GameUI.OK.canceled += ctx => ifOK = false;

            //controls.GameUI.Exit.performed += ctx => ifExit = true;
            //controls.GameUI.Exit.canceled += ctx => ifExit = false;

        }

        private void Start()
        {
            lastStatus = currentStatus = Constants.GameStatus.Normal;
        }

        private void Update()
        {
            if (lastStatus != currentStatus)
            {
                lastStatus = currentStatus;
                ChangeGameStatus(currentStatus);
            }
        }

        // change input control based on current game status
        public void ChangeGameStatus(Constants.GameStatus status)
        {
            switch (status)
            {
                case Constants.GameStatus.Normal:
                    //Debug.Log("the scene is changed to normal");
                    controls.GamePlay.Enable();
                    controls.GameUI.Disable();
                    break;
                case Constants.GameStatus.CutScene:
                    // only startButton enble
                    //Debug.Log("the scene is changed to cutscene");
                    controls.GamePlay.Disable();
                    controls.GameUI.Disable();
                    break;
                case Constants.GameStatus.MenuScene:
                    controls.GameUI.Enable();
                    controls.GamePlay.Disable();
                    break;
                case Constants.GameStatus.PlayerAttack:
                   // Debug.Log("the scene is changed to attack");
                    controls.GamePlay.Jump.Disable();
                    controls.GamePlay.PlayerMove.Disable();
                    break;
            }
        }

        private void OnEnable()
        {
            controls.GamePlay.Enable();
            controls.GameUI.Enable();
        }

        private void OnDisable()
        {
            controls.GamePlay.Disable();
            controls.GameUI.Disable();
        }
    }

}

