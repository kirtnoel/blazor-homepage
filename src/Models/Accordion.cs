using System.Drawing;

namespace BlazorWebApp.Models
{
    public class Accordion
    {

        public Dictionary<string, object> AccordionAttributes { get; }
        public Dictionary<string, object> HeaderAttributes { get; }
        public Dictionary<string, object> ButtonAttributes { get; }
        public Dictionary<string, object> DivAttributues { get; }
        public Dictionary<string, object> BodyAttributes { get; }

        public Accordion(string id)
        {

            AccordionAttributes = new Dictionary<string, object>
            {
                { "class", "accordion" },
                { "id", $"accordion{id}" },
            };

            HeaderAttributes = new Dictionary<string, object>
            {
                { "class", "accordion-header" },
                {  "id", $"heading{id}" }
            };

            ButtonAttributes = new Dictionary<string, object>
            {
                { "class", "accordion-button"},
                { "type", "button"},
                { "data-bs-toggle", "collapse"},
                { "data-bs-target", $"#collapse{id}"},
                { "aria-expanded", "true"},
                { "aria-controls", $"collapse{id}" }
            };

            DivAttributues = new Dictionary<string, object>
            {
                { "id", $"collapse{id}"},
                { "class", "accordion-collapse collapse"},
                { "aria-labelledby", HeaderAttributes["id"] },
                // { "aria-labelledby", HeaderAttributes["id"] },
                { "data-bs-parent", $"#{AccordionAttributes["id"]}" }
            };

            BodyAttributes = new Dictionary<string, object>
            {
                { "class", "accordion-body"},
            };

        }

    }
}
