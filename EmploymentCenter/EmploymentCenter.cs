using System;
using System.Collections.Generic;

namespace EmploymentCenter
{
    [Serializable]
    public class EmploymentCenter
    {
        public List<WorkOffer> AvailableOffers;
        public List<Applicant> Applicants;

        public EmploymentCenter()
        {
            AvailableOffers = new List<WorkOffer>();
            Applicants = new List<Applicant>();
        }
    }
}