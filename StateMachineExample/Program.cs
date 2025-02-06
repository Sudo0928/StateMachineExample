using StateMachineExample.StateMachineSystem;

namespace StateMachineExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StateMachine machine = new StateMachine();

            machine.ChangeState(machine.Village);

            while (true)
            {
                machine.Update();
            }
        }
    }
}
