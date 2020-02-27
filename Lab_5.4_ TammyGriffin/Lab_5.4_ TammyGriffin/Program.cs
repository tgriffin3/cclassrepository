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

            Console.WriteLine(mario.isJumping = true);
            Console.WriteLine(mario.isJumping = false);
            Console.WriteLine(mario.numOfLives +=1);
            Console.WriteLine(mario.canShootFireBalls = true);
            Console.WriteLine(mario.sizeOfMario = Mario.Size.big);
            Console.WriteLine(mario.numOfCoins = 10);
            Console.WriteLine(mario.currentLevel = "World 1-2");

        }
    }
}
