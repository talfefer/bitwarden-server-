using Bit.Core.Entities;
using Bit.Core.Enums;

namespace Bit.Test.Common.Factories
{
    public static class PolicyFactory
    {

        public static Policy CreatePolicy()
        {
            return new Policy
            {
                Id = Guid.NewGuid(),
                OrganizationId = Guid.NewGuid(),
                Type = PolicyType.Password,
                Data = "{}",
                Enabled = true,
            };
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
