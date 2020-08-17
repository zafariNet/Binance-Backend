using System.Collections.Generic;
using Maya.Project.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace Maya.Project.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
