using System;

namespace ApplicationData.Models.ViewModels
{
    public class ApplicantsView
    {
        public int AppliedJobId { get; set; }
        public string ApplicantsTitle { get; set; }
        public string ApplicantsCity { get; set; }
        public string MinSalaryAndMaxSalary { get; set; }
        public string JobTag { get; set; }
        public string ApplicantsId { get; set; }
        public int JobId { get; set; }
        public string ApplicantsName { get; set; }
        public string JobTitle { get; set; }
        public string JobPostedBy { get; set; }
        public DateTime AppliedDate { get; set; }
        
    }
}