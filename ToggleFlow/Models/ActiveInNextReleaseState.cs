namespace ToggleFlow.Models
{
    class ActiveInNextReleaseState : ToggleState
    {
        private readonly FeatureToggle _featureToggle;

        public ActiveInNextReleaseState(FeatureToggle featureToggle)
        {
            _featureToggle = featureToggle;
        }
        
        public void Move()
        {
            _featureToggle.TransitionToState(new ActiveState(_featureToggle));
        }
    }
}