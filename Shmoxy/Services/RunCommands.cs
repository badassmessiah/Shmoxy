using Medallion.Shell;


namespace Shmoxy.Services
{
    public static class RunCommands
    {
        public async static void ExecuteCommand()
        {
            var commamnd = Command.Run("cmd", "/c echo hello, world!");
            commamnd.Wait();
            var output = await commamnd.Task;

            if (output.Success)
            {
                Console.WriteLine(output.StandardOutput);
            }
            else
            {
                Console.WriteLine(output.StandardError);
            }
        }
    }
}