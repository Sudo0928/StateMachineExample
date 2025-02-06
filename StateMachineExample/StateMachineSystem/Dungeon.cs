using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineExample.StateMachineSystem
{
    internal class Dungeon : SceneState
    {
        public Dungeon(StateMachine machine) : base(machine)
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
            Console.WriteLine("Dungeon");

            string str = Console.ReadLine();
            if (str == "Inventory")
            {
                stateMachine.ChangeState(stateMachine.Inventory);
            }
            else if (str == "Village")
            {
                stateMachine.ChangeState(stateMachine.Village);
            }
        }
    }
}
