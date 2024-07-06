using System.Globalization;

namespace BlazorWebApp.Models
{
    public class Language
    {
        public string Current { get; private set; }

        public Language()
        {
            Current = CultureInfo.CurrentCulture.Name.StartsWith("fr") ? Constants.French : Constants.English;
        }

        public void SwitchLanguage()
        {
            Current = Current == Constants.French ? Constants.English : Constants.French;
        }

    }
}
