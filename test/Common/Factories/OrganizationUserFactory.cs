using Bit.Core.Entities;
using Bit.Core.Enums;

namespace Bit.Test.Common.Factories
{
    public static class OrganizationUserFactory
    {
        public static OrganizationUser ConnectTo(this Organization org, User user)
        {
            var orgUser = CreateOrganizationUser();
            orgUser.OrganizationId = org.Id;
            orgUser.UserId = user.Id;
            return orgUser;
        }

        public static OrganizationUser ConnectTo(this User user, Organization organization)
        {
            var orgUser = CreateOrganizationUser();
            orgUser.UserId = user.Id;
            orgUser.OrganizationId = organization.Id;
            return orgUser;
        }

        public static OrganizationUser CreateOrganizationUser()
        {
            return new OrganizationUser
            {
                Id = Guid.NewGuid(),
                OrganizationId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                Email = "test@email.com",
                Key = "Key",
                ResetPasswordKey = null,
                Status = OrganizationUserStatusType.Accepted,
                Type = OrganizationUserType.User,
                AccessAll = false,
                ExternalId = "test@email.com",
            };
        }
    }
}
