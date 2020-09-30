using System;
using JobHub.Models.Resume;

namespace JobHub.Models
{
    public class MyCvView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProfessionalTitle { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PhotoUrl { get; set; }
        public string Objective { get; set; }
        public string KeySkill {get;set;}
        public Experience Experience {get;set;}
        public Education Education { get; set; }
        public Specialization Specialization {get;set;}
        public ProfileSummary ProfileSummary {get;set;}
        public JobPreference JobPreference {get;set;}
    }
}