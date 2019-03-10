﻿using System;
using System.Collections.Generic;
using Yahtzee.Domain;

namespace Yahtzee
{
    internal class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            var game = new Game();

            game.Initialize(new[] { "John" }, new[] { "Jane" });

            game.Play((turn) => { return Console.ReadLine(); });

            Console.ReadKey();
        }

        /// <summary>
        /// Setups the player instances.
        /// </summary>
        /// <param name="humansCount">The humans count.</param>
        /// <param name="computerCount">The computer count.</param>
        /// <returns></returns>
        private static List<Player> SetupPlayerInstances(int humansCount, int computerCount)
        {
            throw new NotImplementedException();
        }
    }
}