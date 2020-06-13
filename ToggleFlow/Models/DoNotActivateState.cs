namespace ToggleFlow.Models
{
    class DoNotActivateState : ToggleState
    {
        private readonly FeatureToggle _featureToggle;

        public DoNotActivateState(FeatureToggle featureToggle)
        {
            _featureToggle = featureToggle;
        }
        
        public void Move()
        {
            _featureToggle.TransitionToState(new ActiveInNextReleaseState(_featureToggle));
        }
    }
}