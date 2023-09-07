using Mf.Debugging;

namespace Mf
{
    public class MfConsts
    {
        public const string LocalizationSourceName = "Mf";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "093eabc1cbad4d538a210202bd355310";
    }
}
