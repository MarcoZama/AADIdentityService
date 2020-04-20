using System.Linq;

namespace AADIdentityService.Authorization
{
    /// <summary>
    /// Actions that can be done on the API
    /// </summary>
    internal static class Actions
    {
        public const string ReadJoys = "Joys/Read";
        public const string ReadOtherJoys = "OtherJoys/Read";

        public static string[] All => typeof(Actions)
            .GetFields()
            .Where(f => f.Name != nameof(All))
            .Select(f => f.GetValue(null) as string)
            .ToArray();
    }
}
