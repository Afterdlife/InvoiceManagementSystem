using InvoiceManagementSystem.Debugging;

namespace InvoiceManagementSystem;

public class InvoiceManagementSystemConsts
{
    public const string LocalizationSourceName = "InvoiceManagementSystem";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "3ccbcb3e6d324a4f9532b01c52a9d1ee";
}
