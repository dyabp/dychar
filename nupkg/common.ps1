# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
$rootFolder = Join-Path $packFolder "../"

# List of solutions
$solutions = (
    "modules/language-management"
)

# List of projects
$projects = (

    # framework

    # modules/language-management
    "modules/language-management/src/Dyabp.LanguageManagement.Application.Contracts",
    "modules/language-management/src/Dyabp.LanguageManagement.Application",
    "modules/language-management/src/Dyabp.LanguageManagement.Domain",
    "modules/language-management/src/Dyabp.LanguageManagement.Domain.Shared",
    "modules/language-management/src/Dyabp.LanguageManagement.EntityFrameworkCore",
	"modules/language-management/src/Dyabp.LanguageManagement.HttpApi",
    "modules/language-management/src/Dyabp.LanguageManagement.HttpApi.Client",
    "modules/language-management/src/Dyabp.LanguageManagement.Web" 
)
