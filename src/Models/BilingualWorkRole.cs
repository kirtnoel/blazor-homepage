
namespace BlazorWebApp.Models;

public class BilingualWorkRole
{   
    public string Id { get; set; }
    public bool IsMandate { get; set; } = false;
    public BilingualStringField? Title { get; set; }
    public BilingualStringField? Organization {get; set;}
    public BilingualStringField? Mandate { get; set; }
    public BilingualStringField Location { get; set; }
    public BilingualStringField? Description { get; set; }
    public BilingualStringField? Team { get; set; }
    public required DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public List<BilingualStringField> Activities { get; set; } = [];
}

