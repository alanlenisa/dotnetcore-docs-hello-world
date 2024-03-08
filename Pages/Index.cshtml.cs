using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;
using TestAppConfig;

namespace dotnetcoresample.Pages;

public class IndexModel : PageModel
{

    public string OSVersion { get { return RuntimeInformation.OSDescription; }  }
    public string OPT {get;set;}
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(IOptionsSnapshot<Settings> options,ILogger<IndexModel> logger)
    {
        _logger = logger;
        OPT=options.Opt;
    }

    public void OnGet()
    {        
    }
}
