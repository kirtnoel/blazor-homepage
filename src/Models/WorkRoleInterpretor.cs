using System.Globalization;

namespace BlazorWebApp.Models
{
    public class WorkRoleInterpretor
    {
        private readonly CultureInfo _culture;
        private readonly string _presentDay;
        private readonly Language _language;
        private readonly BilingualWorkRole _bilingualWorkRole;

        public WorkRoleInterpretor(BilingualWorkRole bilingualWorkRole, Language lanuage)
        {
            _bilingualWorkRole = bilingualWorkRole;
            _language = lanuage;
            _culture = CultureInfo.CreateSpecificCulture((_language.Current == Constants.English) ? "en-CA" : "fr-Fr");
            _presentDay = (_language.Current == Constants.English) ? "present" : "aujourd'hui";
        }

        public string Id => _bilingualWorkRole.Id;
        public string? Title => (_language.Current == Constants.English) ? _bilingualWorkRole.Title?.En : _bilingualWorkRole.Title?.Fr;
        public string? Employer => (_language.Current == Constants.English) ? _bilingualWorkRole.Organization?.En : _bilingualWorkRole.Organization?.Fr;
        public string Location => (_language.Current == Constants.English) ? _bilingualWorkRole.Location.En : _bilingualWorkRole.Location.Fr;
        public string? Mandate => (_language.Current == Constants.English) ? _bilingualWorkRole.Mandate?.En : _bilingualWorkRole.Mandate?.Fr;
        public string? Description => (_language.Current == Constants.English) ? _bilingualWorkRole.Description?.En : _bilingualWorkRole.Description?.Fr;
        public string? Team => (_language.Current == Constants.English) ? _bilingualWorkRole.Team?.En : _bilingualWorkRole.Team?.Fr;
        public string StartDate => _bilingualWorkRole.StartDate.ToString("yyyy MMMM", _culture);
        public string? EndDate => (_bilingualWorkRole.EndDate != null) ? _bilingualWorkRole.EndDate?.ToString("yyyy MMMM", _culture) : _presentDay;
        public List<string> Activities => (_language.Current == Constants.English)
                                                ? _bilingualWorkRole.Activities.Select(i => i.En).ToList()
                                                : _bilingualWorkRole.Activities.Select(i => i.Fr).ToList();
                                    

    }
}
