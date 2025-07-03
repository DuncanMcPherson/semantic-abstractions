namespace SemanticRelease.Abstractions
{
    /// <summary>
    /// Represents a plugin interface responsible for integrating with the semantic release lifecycle.
    /// </summary>
    public interface ISemanticPlugin
    {
        /// <summary>
        /// Registers the semantic plugin with the specified semantic release lifecycle.
        /// </summary>
        /// <param name="lifecycle">The semantic release lifecycle to register the plugin with.</param>
        void Register(SemanticLifecycle lifecycle);
    }
}