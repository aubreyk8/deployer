namespace deployer.Deploy
{
    public class NuxtDeployment : BaseDeployer, DeployerInterface
    {
        private Configurations config {get; set; }

        public NuxtDeployment(Configurations config)
        {
            this.config = config;;
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