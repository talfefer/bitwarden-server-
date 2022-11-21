﻿using Bit.Core.Entities;

namespace Bit.Core.Repositories;

public interface ISecretRepository
{
    Task<IEnumerable<Secret>> GetManyByOrganizationIdAsync(Guid organizationId);
    Task<IEnumerable<Secret>> GetManyByIds(IEnumerable<Guid> ids);
    Task<IEnumerable<Secret>> GetManyByProjectIdAsync(Guid projectId);
    Task<Secret> GetByIdAsync(Guid id);
    Task<Core.Entities.Secret> CreateAsync(Secret secret, Guid? projectId);
    Task ReplaceAsync(Secret secret);
    Task SoftDeleteManyByIdAsync(IEnumerable<Guid> ids);
}