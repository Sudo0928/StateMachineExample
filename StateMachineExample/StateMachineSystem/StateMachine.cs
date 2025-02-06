using StateMachineExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineExample.StateMachineSystem
{
    internal class StateMachine
    {
        private IState currentState;
        private Stack<IState> preStats = new Stack<IState>();

        public Village Village { get; }
        public Dungeon Dungeon { get; }
        public Inventory Inventory { get; }
        public Equip Equip { get; }

        public StateMachine()
        {
            Village = new Village(this);
            Dungeon = new Dungeon(this);
            Equip = new Equip(this);
            Inventory = new Inventory(this);
        }

        public void ChangeState(IState state)
        {
            currentState?.Exit();

            if(currentState != null) preStats.Push(currentState);
            currentState = state;

            currentState?.Enter();
        }

        public void ClearPre()
        {
            if(preStats.Count > 0)
            {
                IState state = preStats.Pop();
                preStats.Clear();
                preStats.Push(state);
            }
        }

        public void BackState()
        {
            currentState?.Exit();

            currentState = preStats.Pop();

            currentState?.Enter();
        }

        public void Update()
        {
            currentState.Update();
        }
    }
}
