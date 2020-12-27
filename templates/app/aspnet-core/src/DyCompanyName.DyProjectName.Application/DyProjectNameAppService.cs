using System;
using System.Collections.Generic;
using System.Text;
using DyCompanyName.DyProjectName.Localization;
using Volo.Abp.Application.Services;

namespace DyCompanyName.DyProjectName
{
    /* Inherit your application services from this class.
     */
    public abstract class DyProjectNameAppService : ApplicationService
    {
        protected DyProjectNameAppService()
        {
            LocalizationResource = typeof(DyProjectNameResource);
        }
    }
}
