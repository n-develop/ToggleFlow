namespace ToggleFlow.Models
{
    class ActiveState : ToggleState
    {
        private readonly FeatureToggle _featureToggle;

        public ActiveState(FeatureToggle featureToggle)
        {
            _featureToggle = featureToggle;
        }
        
        public void Move()
        {
            _featureToggle.TransitionToState(new RemovedState());
        }
    }
}