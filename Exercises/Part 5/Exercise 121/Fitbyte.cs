﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_121;

namespace Exercise_121
{
    class Fitbyte
    {
        int age;
        int restingHeartRate;

        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
        }

        public double TargetHeartRate(double percentageOfMaximum)
        {
            double maxHeartRate = 206.3 - (0.711 * age);
            return (maxHeartRate - restingHeartRate) * percentageOfMaximum + restingHeartRate;
        }
    }
}
