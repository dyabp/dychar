using DyCompanyName.DyProjectName.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace DyCompanyName.DyProjectName.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DyProjectNamePageModel : AbpPageModel
    {
        protected DyProjectNamePageModel()
        {
            LocalizationResourceType = typeof(DyProjectNameResource);
        }
    }
}