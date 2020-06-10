using System;
using System.Collections.Generic;
using System.Linq;

namespace EmploymentCenter
{
    [Serializable]
    public class Applicant
    {
        
        public string FullName { get; set; }
        public int Experience { get; set; }
        public string Address { get; set; }
        public Qualification Qualification { get; set; }
        public bool WantOnlyQualificationWork { get; set; }
        public List<WorkOffer> ConsideredOffers { get; }
        
        /// <summary>
        /// Возвращает список доступных претенденту вакансий
        /// </summary>
        /// <param name="center"></param>
        /// <returns></returns>
        public List<WorkOffer> GetWorkOffers(EmploymentCenter center)
        {
            return center.AvailableOffers.Where(this.CheckWorkOffer).ToList();
        }

        /// <summary>
        /// Проверяет подходит ли данная вакансия претенденту
        /// </summary>
        /// <param name="offer">вакансия</param>
        /// <returns>Результат проверки</returns>
        public bool CheckWorkOffer(WorkOffer offer)
        {
            if (Qualification == offer.RequiredQualification)
                return true;
            if (WantOnlyQualificationWork)
                return false;
            if (offer.RequiredQualification == Qualification.Not)
                return true;
            return false;
        }
        
        /// <summary>
        /// Помечает вакансию как рассматриваемую данным претендентом
        /// </summary>
        /// <param name="offer">вакансия которую нужно пометить как рассматриваемую</param>
        public void RespondOffer(WorkOffer offer)
        {
            ConsideredOffers.Add(offer);
        }
        
        public Applicant(string fullName, int experience,  string address, 
            Qualification qualification, bool wantOnlyQualificationWork)
        {
            FullName = fullName;
            Experience = experience;
            Address = address;
            Qualification = qualification;
            WantOnlyQualificationWork = wantOnlyQualificationWork;
            ConsideredOffers = new List<WorkOffer>();
        }
    }
}