using CommandLine;

public class Options
{
    [Option('c', "code", Required = true, HelpText = "The 'code' argument.")]
    public required string Code { get; set; }
}