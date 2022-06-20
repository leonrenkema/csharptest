using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace csharptest.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public String xmlText { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var p = new Patient();
        p.Deceased = new FhirBoolean(false);
        var serializer = new FhirXmlSerializer();
        xmlText = serializer.SerializeToString(p);
    }
}
