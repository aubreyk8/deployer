using System;
using deployer.Deploy;

namespace deployer
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Deploying application ...");

            BootStrap bootStrap = new BootStrap((new Configurations()).GetConfigurations());
            DeployerInterface deployer = bootStrap.Boot();

            string currentVersion = deployer.getCurrentVersion();

            try {

                deployer.Run();
                Console.WriteLine("Application deployed!");

                return 0;
                
            } catch (Exception e) {
                Console.WriteLine($"Deployment failed with error: { e.Message }");
                
                try
                {
                    Console.WriteLine($"Attempting to revert application to git commit { currentVersion }");
                    deployer.Revert(currentVersion);
                    return 1;

                }catch (Exception r) {
                    Console.WriteLine("Oops!! An attempt to revert application to previous version failed, put your big boy pants on and get to work. ");
                    Console.WriteLine($"Error detail: { r.Message }");
                    return 1;
                }
            }
        }
    }
}
