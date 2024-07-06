
using System.IO;
using YamlDotNet.Serialization;


namespace BlazorWebApp.Models;

public class YamlDeserializer
{   
    Deserializer _deserializer;

    public YamlDeserializer()
    {
        _deserializer = new Deserializer();
    }

    public List<SkillSet> GetTechSkills()
    {
        _deserializer = new Deserializer();
        using var reader = File.OpenText(@"./Data/TechSkills-ProgrammingLanguages.yml");
        return _deserializer.Deserialize<List<SkillSet>>(reader);
    }

    public List<CloudCertifications> GetCloudCertifcations()
    {
        _deserializer = new Deserializer();
        using var reader = File.OpenText(@"./Data/TechSkills-CloudCertifications.yml");
        return _deserializer.Deserialize<List<CloudCertifications>>(reader);
    }

    public List<SkillSet> GetDevTools()
    {
        _deserializer = new Deserializer();
        using var reader = File.OpenText(@"./Data/SkillSet-DevTools.yml");
        return _deserializer.Deserialize<List<SkillSet>>(reader);
    }

    public List<BilingualWorkRole> GetMandates()
    {
        List<BilingualWorkRole> workRoles = new List<BilingualWorkRole>();
        foreach (var file in Directory.EnumerateFiles(@".\Data\Mandates\", "*.yml"))
        {
            _deserializer = new Deserializer();
            using var reader = File.OpenText(file);
            workRoles.AddRange(_deserializer.Deserialize<List<BilingualWorkRole>>(reader));
        }
        return workRoles;
    }

    public BilingualWorkRole GetBBMRole()
    {
        return GetRole(@".\Data\Role-BBM.yml");
    }

    public BilingualWorkRole GetMcKessonRole()
    {
        return GetRole(@".\Data\Role-McKesson.yml");
    }

    private BilingualWorkRole GetRole(string ymlFilePath)
    {
        _deserializer = new Deserializer();
        using var reader = File.OpenText(ymlFilePath);
        return _deserializer.Deserialize<BilingualWorkRole>(reader);
    }

    public List<BilingualWorkRole> GetPatientCareRoles()
    {
        _deserializer = new Deserializer();
        using var reader = File.OpenText(@"./Data/Roles-PatientCare.yml");
        return _deserializer.Deserialize<List<BilingualWorkRole>>(reader);
    }

    public List<BilingualWorkRole> GetLaboratoryRoles()
    {
        _deserializer = new Deserializer();
        using var reader = File.OpenText(@"./Data/Roles-LaboratoryServices.yml");
        return _deserializer.Deserialize<List<BilingualWorkRole>>(reader);
    }

}



