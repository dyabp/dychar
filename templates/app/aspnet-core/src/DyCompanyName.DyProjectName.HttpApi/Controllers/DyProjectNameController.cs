using DyCompanyName.DyProjectName.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DyCompanyName.DyProjectName.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DyProjectNameController : AbpController
    {
        protected DyProjectNameController()
        {
            LocalizationResource = typeof(DyProjectNameResource);
        }
    }
}