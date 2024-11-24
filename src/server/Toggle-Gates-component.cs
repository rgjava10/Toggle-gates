using LogicAPI.Server.Components;

namespace ToggleGates
{
    public class Toggle_Gate : LogicComponent
    {
        private bool toggleState = false;
        private bool previousInput = false;

        protected override void DoLogicUpdate()
        {
            bool currentInput = base.Inputs[0].On;

           
            if (currentInput && !previousInput)
            {
                toggleState = !toggleState; 
            }

            base.Outputs[0].On = toggleState;

           
            previousInput = currentInput;
        }
    }
}