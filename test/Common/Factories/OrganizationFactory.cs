using Bit.Core.Entities;
using Bit.Core.Enums;
using Bit.Core.Utilities;

namespace Bit.Test.Common.Factories
{
    public static class OrganizationFactory
    {
        public static Organization CreateOrganization(PlanType planType)
        {
            var organization = new Organization
            {
                Id = Guid.NewGuid(),
                Name = "Test Organization",
                Enabled = true,
                PlanType = PlanType.Free,
                UseKeyConnector = false,
                LicenseKey = "LicenseKey",
                PublicKey = "PublicKey",
                PrivateKey = "2.QmFzZTY0UGFydA==|QmFzZTY0UGFydA==|QmFzZTY0UGFydA==",
                TwoFactorProviders = null,
                ExpirationDate = null,
                CreationDate = DateTime.UtcNow
            };

            switch (planType)
            {
                case PlanType.Free:
                    return organization.ApplyPlan(PlanType.Free);
                case PlanType.FamiliesAnnually2019:
                    return organization.ApplyPlan(PlanType.FamiliesAnnually2019);
                case PlanType.TeamsMonthly2019:
                    return organization.ApplyPlan(PlanType.TeamsMonthly2019);
                case PlanType.TeamsAnnually2019:
                    return organization.ApplyPlan(PlanType.TeamsAnnually2019);
                case PlanType.EnterpriseMonthly2019:
                    return organization.ApplyPlan(PlanType.EnterpriseMonthly2019);
                case PlanType.EnterpriseAnnually2019:
                    return organization.ApplyPlan(PlanType.EnterpriseAnnually2019);
                case PlanType.Custom:
                    return organization.ApplyPlan(PlanType.Custom);
                case PlanType.FamiliesAnnually:
                    return organization.ApplyPlan(PlanType.FamiliesAnnually);
                case PlanType.TeamsMonthly:
                    return organization.ApplyPlan(PlanType.TeamsMonthly);
                case PlanType.TeamsAnnually:
                    return organization.ApplyPlan(PlanType.TeamsAnnually);
                case PlanType.EnterpriseMonthly:
                    return organization.ApplyPlan(PlanType.EnterpriseMonthly);
                case PlanType.EnterpriseAnnually:
                    return organization.ApplyPlan(PlanType.EnterpriseAnnually);
                default:
                    throw new NotImplementedException();
            }
        }
    }

    public static class ApplyExtension
    {
        public static Organization ApplyPlan(this Organization org, PlanType planType)
        {
            var plan = StaticStore.GetPlan(planType);

            org.Plan = plan.Name;
            org.PlanType = planType;
            org.Seats = plan.BaseSeats + (plan.MaxAdditionalSeats ?? 0) / 2;
            org.MaxStorageGb = plan.BaseStorageGb;
            org.Storage = org.MaxStorageGb.HasValue ? org.MaxStorageGb / 2 : null;
            org.MaxCollections = plan.MaxCollections;
            org.MaxStorageGb = plan.BaseStorageGb;
            org.UsePolicies = plan.HasPolicies;
            org.UseSso = plan.HasSso;
            org.UseGroups = plan.HasGroups;
            org.UseEvents = plan.HasEvents;
            org.UseDirectory = plan.HasDirectory;
            org.UseTotp = plan.HasTotp;
            org.Use2fa = plan.Has2fa;
            org.UseApi = plan.HasApi;
            org.UseResetPassword = plan.HasResetPassword;
            org.SelfHost = plan.HasSelfHost;
            org.UsersGetPremium = plan.UsersGetPremium;

            return org;
        }
    }
}
