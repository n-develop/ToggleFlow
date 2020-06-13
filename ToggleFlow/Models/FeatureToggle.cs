namespace ToggleFlow.Models
{
    public class FeatureToggle
    {
        private ToggleState _state;
        private readonly string _name;

        public FeatureToggle(string name)
        {
            _name = name;
            _state = new DoNotActivateState(this);
        }

        public void TransitionToState(ToggleState state)
        {
            _state = state;
        }

        public void Move()
        {
            _state.Move();
        }
    }
}