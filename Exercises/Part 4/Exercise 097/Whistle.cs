﻿using System;

namespace exercise_97
{
    internal class Whistle
    {
        private string sound;

        public Whistle(string whistleSound)
        {
            this.sound = whistleSound;
        }

        public void Sound()
        {
            Console.WriteLine(sound);
        }

    }
}