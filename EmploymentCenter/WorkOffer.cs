using System;
using System.Collections.Generic;

namespace EmploymentCenter
{
    [Serializable]
    public class WorkOffer
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public int Salary { get; set; }
        public Qualification RequiredQualification { get; set; }

        
        public WorkOffer(string name, string companyName,  int salary, Qualification requiredQualification)
        {
            Name = name;
            CompanyName = companyName;
            Salary = salary;
            RequiredQualification = requiredQualification;
        }
        
        public override bool Equals(Object obj)
        {
            if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            WorkOffer offer = (WorkOffer) obj;
            return (Name == offer.Name) && (CompanyName == offer.CompanyName) && (Salary == offer.Salary) && 
                   (RequiredQualification == offer.RequiredQualification);
        }
    }
}