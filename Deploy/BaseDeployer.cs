using System;
namespace deployer.Deploy
{
    public class BaseDeployer
    {
        public string getCurrentVersion()
        {
            return Bash.Run("git rev-parse HEAD");
        }
    }
}