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
            //Update codebase
            Bash.Run("git pull");

            //Install dependencies based on lock file --no-dev
            Bash.Run("composer install  --no-interaction --prefer-dist --optimize-autoloader --no-dev");

            if (this.config.Migrate) {
                //Migrate database
                Bash.Run("php artisan migrate --force");
            }

            if (this.config.Optimize) {
                //# Clear cache
                Bash.Run("php artisan optimize");
            }

            if(this.config.Horizon) {
                // Restart horizon
                Bash.Run("php artisan horizon:terminate");
            }
            
        }

        public void Revert(string commitHash)
        {
            throw new System.NotImplementedException();
        }
    }
}