﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра класса TamagotchiCondition.
            TamagotchiCondition tamagotchiCondition = new TamagotchiCondition();
            // Создание экземпляра класса Tamagotchi.
            Tamagotchi tamagotchi = new Tamagotchi();
            tamagotchiCondition.PrintPetInformation(tamagotchi);
        }
    }
}
