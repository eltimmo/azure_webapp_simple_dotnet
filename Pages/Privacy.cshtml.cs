using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;

namespace dotnetcoresample.Pages;

public class PrivacyModel : PageModel
{

    public string OSVersion { get { return RuntimeInformation.OSDescription; }  }
    public string WebsiteName { get { return Environment.GetEnvironmentVariable("WEBSITE_SITE_NAME"); }  }
    
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

