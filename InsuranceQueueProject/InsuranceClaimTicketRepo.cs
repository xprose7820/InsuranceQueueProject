using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _InsuranceClaimTicketClass;


namespace _InsuranceClaimTicketRepo
{
    public class InsuranceClaimTicketRepo
    {

        private Queue<InsuranceClaimTicketClass> claimTicketsQueueRepo = new Queue<InsuranceClaimTicketClass>();
        public InsuranceClaimTicketRepo()
        {

        }
        public void addNewClaim(InsuranceClaimTicketClass claimTicketObj)
        {
            claimTicketsQueueRepo.Enqueue(claimTicketObj);
        }
        public Queue<InsuranceClaimTicketClass> getQueueRepo()
        {
            return claimTicketsQueueRepo;
        }
        public InsuranceClaimTicketClass seeNextTicket()
        {
            return claimTicketsQueueRepo.Peek();
        }
        public List<InsuranceClaimTicketClass> listOfTickets()
        {
            Queue<InsuranceClaimTicketClass> tempQueueRepo = new Queue<InsuranceClaimTicketClass>(claimTicketsQueueRepo);
            List<InsuranceClaimTicketClass> tempListRepo = new List<InsuranceClaimTicketClass>();

            foreach (InsuranceClaimTicketClass claimTicketObj in claimTicketsQueueRepo)
            {
                tempListRepo.Add(tempQueueRepo.Dequeue());

            }
            return tempListRepo;
        }
        public void processTicket()
        {
            claimTicketsQueueRepo.Dequeue();
        }


    }
}