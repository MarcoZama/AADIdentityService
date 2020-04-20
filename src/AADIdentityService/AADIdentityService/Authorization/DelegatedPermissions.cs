using System.Linq;

namespace AADIdentityService.Authorization
{
    internal static class DelegatedPermissions
    {
        public const string ReadThings = "Joys.Read";
        public const string ReadOtherThings = "OtherJoys.Read";

        public static string[] All => typeof(DelegatedPermissions)
            .GetFields()
            .Where(f => f.Name != nameof(All))
            .Select(f => f.GetValue(null) as string)
            .ToArray();
    }
}
