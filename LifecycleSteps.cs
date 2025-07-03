namespace SemanticRelease.Abstractions
{
    public static class LifecycleSteps
    {
        public const string VerifyConditions = "verifyConditions";
        public const string AnalyzeCommits = "analyzeCommits";
        public const string GenerateNotes = "generateNotes";
        public const string Prepare = "prepare";
        public const string Publish = "publish";
        public const string Success = "success";
        public const string Fail = "fail";
    }
}