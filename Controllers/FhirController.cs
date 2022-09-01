using Microsoft.AspNetCore.Mvc;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace csharptest.Controllers
{
    public class FhirController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            var ai = new AllergyIntolerance();
            var refe = new ResourceReference();
            refe.Type = "patient";

            ai.Patient = refe;
            ai.Criticality = AllergyIntolerance.AllergyIntoleranceCriticality.Low;
            ai.ClinicalStatus = new CodeableConcept("http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", "inactive", "Inactive");

            // var p = new Patient();
            // p.Deceased = new FhirBoolean(false);
            var serializer = new FhirJsonSerializer();

            return new JsonResult(ai);
        }
    }
}