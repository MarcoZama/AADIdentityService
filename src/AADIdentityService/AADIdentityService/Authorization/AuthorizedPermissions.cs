using System.Collections.Generic;

namespace AADIdentityService.Authorization
{
    internal static class AuthorizedPermissions
    {
        /// <summary>
        /// Contains the allowed delegated permissions for each action.
        /// If the caller has one of the allowed ones, they should be allowed
        /// to perform the action.
        /// </summary>
        public static IReadOnlyDictionary<string, string[]> DelegatedPermissionsForActions = new Dictionary<string, string[]>
        {
            [Actions.ReadJoys] = new[] { DelegatedPermissions.ReadThings },
            [Actions.ReadOtherJoys] = new[] { DelegatedPermissions.ReadOtherThings }
        };

        /// <summary>
        /// Contains the allowed application permissions for each action.
        /// If the caller has one of the allowed ones, they should be allowed
        /// to perform the action.
        /// </summary>
        public static IReadOnlyDictionary<string, string[]> ApplicationPermissionsForActions = new Dictionary<string, string[]>
        {
            [Actions.ReadJoys] = new[] { ApplicationPermissions.ReadAllThings },
            [Actions.ReadOtherJoys] = new[] { ApplicationPermissions.ReadAllOtherThings }
        };
    }
}
