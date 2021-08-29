
namespace deployer.Deploy
{
    public interface DeployerInterface
    {
        public void Run();
        public void Revert(string commitHash);

        public string getCurrentVersion();
    }
}