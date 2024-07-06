namespace BlazorWebApp.Models;

public class SkillSet
{
    public int Years { get; set; }
    public string Label {get; set;}
    public required BilingualCompetency Rating { get; set; }
}