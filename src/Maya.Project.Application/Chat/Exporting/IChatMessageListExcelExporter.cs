using System.Collections.Generic;
using Abp;
using Maya.Project.Chat.Dto;
using Maya.Project.Dto;

namespace Maya.Project.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
