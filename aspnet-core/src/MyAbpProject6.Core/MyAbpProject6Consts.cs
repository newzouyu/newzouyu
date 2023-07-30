using MyAbpProject6.Debugging;

namespace MyAbpProject6
{
    public class MyAbpProject6Consts
    {
        public const string LocalizationSourceName = "MyAbpProject6";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "d6e5c7f12aed4ec89819e969a4c37df1";
    }
}
