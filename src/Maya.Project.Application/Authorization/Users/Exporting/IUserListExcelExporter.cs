using System.Collections.Generic;
using Maya.Project.Authorization.Users.Dto;
using Maya.Project.Dto;

namespace Maya.Project.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}