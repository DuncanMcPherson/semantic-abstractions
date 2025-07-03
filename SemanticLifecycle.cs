using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SemanticRelease.Abstractions
{
    /// <summary>
    /// Represents the core lifecycle of a semantic release process, managing different stages
    /// and facilitating the integration of plugins to extend its functionality.
    /// </summary>
    /// <remarks>
    /// The SemanticLifecycle class provides a structured workflow to execute semantic release operations,
    /// coordinating with plugins to handle tasks like versioning, changelog generation, and artifact release.
    /// </remarks>
    public class SemanticLifecycle
    {
        private readonly Dictionary<string, List<Func<ReleaseContext, Task>>> _steps = new Dictionary<string, List<Func<ReleaseContext, Task>>>();

        private void On(string stage, Func<ReleaseContext, Task> step)
        {
            if (!_steps.ContainsKey(stage))
            {
                _steps.Add(stage, new List<Func<ReleaseContext, Task>>());
            }
            _steps[stage].Add(step);
        }

        public void OnVerifyConditions(Func<ReleaseContext, Task> step) => On(LifecycleSteps.VerifyConditions, step);
        public void OnAnalyzeCommits(Func<ReleaseContext, Task> step) => On(LifecycleSteps.AnalyzeCommits, step);
        public void OnGenerateNotes(Func<ReleaseContext, Task> step) => On(LifecycleSteps.GenerateNotes, step);
        public void OnPrepare(Func<ReleaseContext, Task> step) => On(LifecycleSteps.Prepare, step);
        public void OnPublish(Func<ReleaseContext, Task> step) => On(LifecycleSteps.Publish, step);
        public void OnSuccess(Func<ReleaseContext, Task> step) => On(LifecycleSteps.Success, step);
        public void OnFail(Func<ReleaseContext, Task> step) => On(LifecycleSteps.Fail, step);

        public async Task RunStep(string stage, ReleaseContext context)
        {
            if (_steps.TryGetValue(stage, out var handlers))
            {
                foreach (var handler in handlers)
                {
                    await handler(context);
                }
            }
        }
        
        public IEnumerable<string> GetSteps() => _steps.Keys;
    }
}