// this file contains all the constants and enum

using System;
using UnityEngine.Events;

namespace myGame
{

    public class Constants
    {
        // scene Order:
        public enum Scenes
        {
            SplashScreen = 0,
            MainMenu,
            RedirectScene,
            DeathScene,
            Level001,
            BossCastle,
            Forest
        };

        // Game Status
        public enum GameStatus
        {
            CutScene, // only can press startButton to skip cutScene
            PlayerAttack, // when player attack, cannot move and jump, run
            Normal, // normal game play, player can move and jump, run
            MenuScene // enter the menuScene, game pause, player cannot move
        }
    }

}
