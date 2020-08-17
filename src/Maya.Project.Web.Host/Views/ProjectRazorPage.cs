using Abp.AspNetCore.Mvc.Views;

namespace Maya.Project.Web.Views
{
    public abstract class ProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected ProjectRazorPage()
        {
            LocalizationSourceName = ProjectConsts.LocalizationSourceName;
        }
    }
}
