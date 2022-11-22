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
            
            var reactionComponents = new List<AllergyIntolerance.ReactionComponent>();
            // reactionComponents.Add(new AllergyIntolerance.ReactionComponent());
            var reaction1 = new AllergyIntolerance.ReactionComponent();
            reaction1.Description = "dd";
            reactionComponents.Add(reaction1);

            ai.Reaction = reactionComponents;

            // var p = new Patient();
            // p.Deceased = new FhirBoolean(false);
            return new JsonResult(ai);
        }
    }
}