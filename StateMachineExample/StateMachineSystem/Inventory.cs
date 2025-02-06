using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineExample.StateMachineSystem
{
    internal class Inventory : SceneState
    {
        public Inventory(StateMachine machine) : base(machine)
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
            Console.WriteLine("Inventory");

            string str = Console.ReadLine();
            if (str == "Equip")
            {
                stateMachine.ChangeState(stateMachine.Equip);
            }
            else if (str == "back")
            {
                stateMachine.BackState();
            }
        }
    }
}
