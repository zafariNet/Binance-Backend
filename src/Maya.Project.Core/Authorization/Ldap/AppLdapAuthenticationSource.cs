using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Maya.Project.Authorization.Users;
using Maya.Project.MultiTenancy;

namespace Maya.Project.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}