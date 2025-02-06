﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineExample.StateMachineSystem
{
    internal class Equip : SceneState
    {
        public Equip(StateMachine machine) : base(machine)
        {
        }

        public override void Enter()
        {

        }

        public override void Exit()
        {
            Console.Clear();
        }

        public override void Update()
        {
            Console.WriteLine("Equip");

            string str = Console.ReadLine();
            if (str == "back")
            {
                stateMachine.BackState();
            }
        }
    }
}
