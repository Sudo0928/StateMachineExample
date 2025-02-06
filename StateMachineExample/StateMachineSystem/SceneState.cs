using StateMachineExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineExample.StateMachineSystem
{
    internal class SceneState : IState
    {
        protected StateMachine stateMachine;

        public SceneState(StateMachine machine)
        {
            stateMachine = machine;
        }

        public virtual void Enter()
        {

        }

        public virtual void Exit()
        {

        }

        public virtual void Update()
        {
            Console.Clear();
        }
    }
}
