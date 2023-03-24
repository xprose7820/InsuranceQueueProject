using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _InsuranceClaimTicketClass
{
    public class InsuranceClaimTicketClass
    {
        private string claimType;
        private string description;
        private string claimAmount;
        private DateTime dateOfIncident;
        private DateTime dateOfClaim;

        private bool isValid;

        
    
        public InsuranceClaimTicketClass(string claimType, string description, string claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            
            this.claimType = claimType;
            this.description = description;
            this.claimAmount = claimAmount;
            this.dateOfIncident = dateOfIncident;
            this.dateOfClaim = dateOfClaim;
            this.isValid = isValidChecker(dateOfIncident, dateOfClaim);


        }

        private bool isValidChecker(DateTime dateOfIncident, DateTime dateOfClaim)
        {
            TimeSpan timeDiff = dateOfClaim.Subtract(dateOfIncident);
            int diffOfDays = timeDiff.Days;
            if (diffOfDays > 30)
            {
                return false;
            }

            return true;
        }
        public string getClaimType()
        {
            return claimType;
        }
        public void setClaimType(string claimType)
        {
            this.claimType = claimType;
        }
        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }


        public string getClaimAmount()
        {
            return claimAmount;
        }

        public void setClaimAmount(string claimAmount)
        {
            this.claimAmount = claimAmount;
        }
        public DateTime getDateOfIncident()
        {
            return dateOfIncident.Date;
        }
        public void setDateOfIncident(DateTime dateOfIncident)
        {
            this.dateOfIncident = dateOfIncident;
        }
        public DateTime getDateOfClaim()
        {
            return dateOfClaim.Date;
        }
        public void setDateOfClaim(DateTime dateOfClaim)
        {
            this.dateOfClaim = dateOfClaim;
        }
        public bool getIsValid(){
            return isValid;
        }
        public void setIsValid(bool val){
            isValid = val;
        }


    }
}