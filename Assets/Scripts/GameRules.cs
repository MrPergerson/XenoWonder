using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AncientAliens
{
    public static class GameRules
    {
        // Wonder
        public static int startWonderProgress = 5;
        public static int maxWonderProgress = 100;
        public static int brickProgressValue = 10;

        // Level
        public static int startingRockCount = 20;

        //UFO
        public static float ufoMaxSpeed = 3.4f;
        public static float ufoCurrentSpeed = 0;
        public static float ufoSandBrickSlowDown = 0.4f;

        // TileObjects
        public static int peopleValue = 5;
        public static int rockValue = 1;
        public static int brickValue = 5;
        public static int barbarianValue = 5;
        public static int cityValue = 10;

        // BarbarianAI
        public static float barbarianActionTick = 1;
        public static int damageToWonder = 2;
        public static int damageToPeople = 5;
        public static int damageToCity = 10;
        public static string[] barbarianTypeFilter = { "Barbarians", "SandBrick", "Wonder" };

        // Combinations
        public static float cityAndPeopleCombineTime = 10;
        public static float peopleAndBarbarianCombineTime = 5;
        public static float peopleAndPeopleCombineTime = 15;
        public static float peopleAndBrickCombineTime = 20;
        public static float peopleAndRockCombineTIme = 8;
        
    }
}
