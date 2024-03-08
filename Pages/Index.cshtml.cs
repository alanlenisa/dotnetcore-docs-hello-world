using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Options;
using TestAppConfig;

namespace dotnetcoresample.Pages;

public class IndexModel : PageModel
{

    public string OSVersion { get { return RuntimeInformation.OSDescription; }  }
    public string OPT {get;set;}
    private readonly ILogger<IndexModel> _logger;

    //public IndexModel(IOptionsSnapshot<Settings> options,ILogger<IndexModel> logger)
     public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
       // OPT=options.Value.Opt;
    }

    public void OnGet()
    {        
        _logger.LogWarning($"Ciao { DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
    }
}
