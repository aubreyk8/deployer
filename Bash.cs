using System;
using System.IO;
using System.Diagnostics;
using deployer.Exceptions;

public class Bash
{
    public static string Run(string command)
    {
        Process process = new Process() {
            StartInfo = new ProcessStartInfo() {
                FileName = "/bin/bash",
                Arguments = $"-c \"{ command }\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            }
        };

        process.Start();

        process.WaitForExit();

        if (process.ExitCode != 0) {
            throw new BashException(process.ExitCode, process.StandardOutput.ReadToEnd());
        }
        
        return process.StandardOutput.ReadToEnd();
    }
}