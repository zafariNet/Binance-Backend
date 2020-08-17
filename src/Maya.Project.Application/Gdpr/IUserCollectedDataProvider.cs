using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Maya.Project.Dto;

namespace Maya.Project.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
