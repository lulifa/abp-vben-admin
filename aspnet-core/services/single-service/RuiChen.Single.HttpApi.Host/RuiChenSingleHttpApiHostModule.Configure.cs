namespace RuiChen.Single.HttpApi.Host;

public partial class RuiChenSingleHttpApiHostModule
{
    public static string ApplicationName { get; set; } = "RuiChenSingle";

    protected const string DefaultCorsPolicyName = "Default";

    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();


}
