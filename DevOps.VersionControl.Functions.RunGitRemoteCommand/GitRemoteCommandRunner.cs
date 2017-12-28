using static DevOps.VersionControl.Functions.RunGitCommand.GitCommandRunner;

namespace DevOps.VersionControl.Functions.RunGitRemoteCommand
{
    public static class GitRemoteCommandRunner
    {
        private const string remote = nameof(remote);

        public static void Remote(string directory, params string[] arguments)
            => Git(directory,
                command: remote,
                arguments);
    }
}
