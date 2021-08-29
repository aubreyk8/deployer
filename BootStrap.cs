using deployer.Deploy;

namespace deployer
{
    public class BootStrap
    {
        private const string LARAVEL = "laravel";
        private const string NUXT = "nuxt";

        private Configurations config { get; set;}
        public BootStrap (Configurations config)
        {
            this.config = config;
        }

        public DeployerInterface Boot()
        {
            switch (this.config.type)
            {
                case LARAVEL:
                    return new LaravelDeployment(this.config);
                case NUXT:
                    return new NuxtDeployment(this.config);
                default:
                    return null;
            }
        }
    }
}