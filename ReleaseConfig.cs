using System.Collections.Generic;

namespace SemanticRelease.Abstractions
{
    /// <summary>
    /// Represents the configuration for a release process.
    /// </summary>
    public class ReleaseConfig
    {
        /// <summary>
        /// Represents a collection of branch names used within the release configuration.
        /// </summary>
        /// <remarks>
        /// This property typically holds the list of branch names that are targeted for releases
        /// and is initialized with a default branch name, such as "main".
        /// </remarks>
        public IReadOnlyList<string> Branches { get; } = new List<string> { "main" };

        public string TagFormat { get; } = "v{version}";
        public Dictionary<string, object>? PluginConfigs { get; }

        public ReleaseConfig(string? tagFormat = null,
            Dictionary<string, object>? pluginConfigs = null, List<string>? branches = null)
        {
            if (branches != null)
            {
                Branches = branches;
            }
            TagFormat = tagFormat ?? "v{version}";
            PluginConfigs = pluginConfigs;
        }
    }
}