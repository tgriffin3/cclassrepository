using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_5._4__TammyGriffin
{
    class Program
    {
    public struct Mario
        {
            public enum Size
            {
                small,
                big
            }

            public int numOfLives;
            public string currentLevel;
            public Size sizeOfMario;
            public bool canShootFireBalls;
            public bool isJumping;
            public int numOfCoins;

        }

        static void Main(string[] args)
        {
            Mario mario = new Mario();
            mario.numOfLives = 3;
            mario.currentLevel = "World 1-1";
            mario.sizeOfMario = Mario.Size.small;
            mario.canShootFireBalls = false;
            mario.isJumping = false;

            Console.WriteLine("Mario is running through the level and meets a Gooba. Set Mario to jumping so he can kill it");
            Console.WriteLine(mario.isJumping = true);
            Console.WriteLine("Mario squashes the Gooba. Now he needs to land!");
            Console.WriteLine(mario.isJumping = false);
            Console.WriteLine("Mario hits a block and finds a 1UP. Increase Mario's life by one.");
            Console.WriteLine(mario.numOfLives +=1);
            Console.WriteLine("Mario finds a secret Fire Flower and can now shoot fireballs. Change mario!");
            Console.WriteLine(mario.canShootFireBalls = true);
            Console.WriteLine("Mario finds another power up mushroom and gets big. Change Mario");
            Console.WriteLine(mario.sizeOfMario = Mario.Size.big);
            Console.WriteLine("Mario finds a stash of gold coins. Give Mario 10 coins.");
            Console.WriteLine(mario.numOfCoins = 10);
            Console.WriteLine("Mario finshes the level! Change Mario's current level to World 1-2");
            Console.WriteLine(mario.currentLevel = "World 1-2");

        }
    }
}
