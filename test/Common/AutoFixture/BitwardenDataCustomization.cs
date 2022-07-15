using AutoFixture;
using Bit.Core.Entities;
using Bit.Core.Enums;
using Bit.Test.Common.Factories;

namespace Bit.Test.Common.AutoFixture
{
    public class BitwardenDataCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customize<Organization>((composer) => composer.FromFactory(() => OrganizationFactory.CreateOrganization(PlanType.Free)));
            fixture.Customize<OrganizationUser>((composer) => composer.FromFactory(() => OrganizationUserFactory.CreateOrganizationUser()));
        }
    }
}
