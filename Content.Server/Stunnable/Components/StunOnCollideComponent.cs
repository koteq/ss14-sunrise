namespace Content.Server.Stunnable.Components
{
    /// <summary>
    /// Adds stun when it collides with an entity
    /// </summary>
    [RegisterComponent, Access(typeof(StunOnCollideSystem))]
    public sealed partial class StunOnCollideComponent : Component
    {
        // TODO: Can probably predict this.

        // See stunsystem for what these do
        [DataField("stunAmount")]
        public float StunAmount;

        [DataField("knockdownAmount")]
        public float KnockdownAmount;

        [DataField("slowdownAmount")]
        public float SlowdownAmount;

        [DataField("walkSpeedMultiplier")]
        public float WalkSpeedMultiplier = 1f;

        [DataField("runSpeedMultiplier")]
        public float RunSpeedMultiplier = 1f;

        /// <summary>
        /// Fixture we track for the collision.
        /// </summary>
        [DataField("fixture")] public string FixtureID = "projectile";
    }
}
