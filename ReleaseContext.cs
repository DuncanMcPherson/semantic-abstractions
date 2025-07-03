using System;

namespace SemanticRelease.Abstractions
{
    public class ReleaseContext
    {
        /// <summary>
        /// Gets the path to the working directory used during the execution of the release process.
        /// </summary>
        /// <remarks>
        /// This property represents the base directory where the release tasks are executed.
        /// It is typically set during the initialization of the release context and cannot be null.
        /// </remarks>
        public string WorkingDirectory { get; }

        /// <summary>
        /// Gets the release configuration settings used during the execution of the release process.
        /// </summary>
        /// <remarks>
        /// This property encapsulates various settings required to define and customize the release workflow,
        /// including branch configurations, CI settings, dry-run mode, and plugin-specific configurations.
        /// It is initialized during the creation of the ReleaseContext and cannot be null.
        /// </remarks>
        public ReleaseConfig Config { get; }

        /// <summary>
        /// Represents the context for a release process, providing access to the working directory
        /// and release configuration.
        /// </summary>
        /// <param name="workingDirectory">
        /// The active working directory to run the release from
        /// </param>
        /// <param name="config">
        /// The config for the release as specified in the json configuration file
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Throws an exception if either <c>workingDirectory</c> or <c>config</c> are not present
        /// </exception>
        public ReleaseContext(string workingDirectory, ReleaseConfig config)
        {
            WorkingDirectory = workingDirectory ?? throw new ArgumentNullException(nameof(workingDirectory));
            Config = config ?? throw new ArgumentNullException(nameof(config));
        }
    }
}