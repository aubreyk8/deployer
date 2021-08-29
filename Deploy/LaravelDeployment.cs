namespace deployer.Deploy
{
    public class LaravelDeployment : BaseDeployer, DeployerInterface
    {
        private Configurations config { get; set; }

        public LaravelDeployment(Configurations config)
        {
            this.config = config;
        }

        public void Run()
        {
            throw new System.NotImplementedException();
        }

        public void Revert(string commitHash)
        {
            throw new System.NotImplementedException();
        }
    }
}