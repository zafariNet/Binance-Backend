using System.Collections.Generic;
using Maya.Project.Authorization.Users.Importing.Dto;
using Maya.Project.Dto;

namespace Maya.Project.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
