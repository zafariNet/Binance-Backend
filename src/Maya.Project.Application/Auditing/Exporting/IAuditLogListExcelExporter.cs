using System.Collections.Generic;
using Maya.Project.Auditing.Dto;
using Maya.Project.Dto;

namespace Maya.Project.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
