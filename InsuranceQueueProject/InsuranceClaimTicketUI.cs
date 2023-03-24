using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _InsuranceClaimTicketClass;
using _InsuranceClaimTicketRepo;
using System.Text;

namespace _InsuranceClaimTicketUI
{

    class InsuranceClaimTicketUI
    {

        public InsuranceClaimTicketUI()
        {

        }
        public void Run()
        {
            InsuranceClaimTicketRepo mainQueueRepo = new InsuranceClaimTicketRepo();
            bool exitProgram = false;
            while (!exitProgram)
            {
                string userMenuChoice = "";
                while (true)
                {
                    System.Console.WriteLine("Welcome to the Insurance Portal.\n" +
                                             "Please select from the following sections:\n" +
                                             "1. Add a new Claim\n" +
                                             "2. View the next Claim\n" +
                                             "3. See a list of all claims\n" +
                                             "4. Process the next Claim\n" +
                                             "5. Exit\n");


                    userMenuChoice = Console.ReadLine();
                    System.Console.WriteLine("\n");
                    if (!(userMenuChoice == "1" || userMenuChoice == "2" || userMenuChoice == "3" || userMenuChoice == "4" || userMenuChoice == "5"))
                    {
                        System.Console.WriteLine("Please select a valid choice.\n");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                switch (userMenuChoice)
                { // adding a claim
                    case "1":
                        {
                            bool stayInCase = true;
                            while (true)
                            {
                                (bool, string) claimTypeExit;

                                while (true)
                                {
                                    System.Console.WriteLine("Press \"esc\" key anytime to return to menu.\n");
                                    System.Console.WriteLine("Please type the Claim Type (i.e. Car, Home, or Theft):\n");
                                    claimTypeExit = checkEscKey();
                                    System.Console.WriteLine("\n");

                                    if (claimTypeExit.Item1 == true)
                                    {
                                        stayInCase = false;
                                        break;
                                    }
                                    if (!(claimTypeExit.Item2 == "Car" || claimTypeExit.Item2 == "Home" || claimTypeExit.Item2 == "Theft"))
                                    {
                                        System.Console.WriteLine("Please type in a valid chioce.\n ");
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }
                                if (stayInCase == false)
                                {
                                    break;
                                }
                                (bool, string) descriptionExit;
                                while (true)
                                {
                                    System.Console.WriteLine("Press \"esc\" key anytime to return to menu.\n");
                                    System.Console.WriteLine("Please enter a description for the Claim:\n");
                                    descriptionExit = checkEscKey();
                                    System.Console.WriteLine("\n");

                                    if (descriptionExit.Item1 == true)
                                    {
                                        stayInCase = false;
                                        break;
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }
                                if (stayInCase == false)
                                {
                                    break;
                                }
                                (bool, string) claimAmountExit;
                                while (true)
                                {
                                    System.Console.WriteLine("Press \"esc\" key anytime to return to menu.\n");
                                    System.Console.WriteLine("Please enter the Claim Amount (whole dollars only):\n");
                                    claimAmountExit = checkEscKey();
                                    System.Console.WriteLine("\n");

                                    if (claimAmountExit.Item1 == true)
                                    {
                                        stayInCase = false;
                                        break;
                                    }
                                    if (int.TryParse(claimAmountExit.Item2, out _) == false)
                                    {
                                        System.Console.WriteLine("Please enter a valid amount.\n");
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }
                                if (stayInCase == false)
                                {
                                    break;
                                }
                                (bool, string) incidentExit;
                                while (true)
                                {
                                    System.Console.WriteLine("Press \"esc\" key anytime to return to menu.\n");
                                    System.Console.WriteLine("Please enter the Date of Incidence, in 00/00/0000 format, where order is month/day/year :\n");
                                    incidentExit = checkEscKey();
                                    System.Console.WriteLine("\n");

                                    if (incidentExit.Item1 == true)
                                    {
                                        stayInCase = false;
                                        break;
                                    }
                                    if (DateTime.TryParse(incidentExit.Item2, out _) == false)
                                    {
                                        System.Console.WriteLine("Please enter a valid date.\n");
                                        continue;
                                    }

                                    else
                                    {
                                        break;
                                    }
                                    // string[] parsedDate = incidentExit.Item2.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                                    // bool continueLoop = true;
                                    // for (int i = 0; i < parsedDate.Length; i++)
                                    // {
                                    //     if (i == 0)
                                    //     {
                                    //         if (int.TryParse(parsedDate[0]) == false)
                                    //         {   
                                    //             continueLoop = true;
                                    //             break;
                                    //         }
                                    //         if(int.Parse(parsedDate[0]) < 1 || int.Parse(parsedDate[0]) > 12){
                                    //             continueLoop = true;
                                    //             break;
                                    //         }

                                    //     }
                                    //     if(i == 1){
                                    //         if (int.TryParse(parsedDate[1]) == false)
                                    //         {   
                                    //             continueLoop = true;
                                    //             break;
                                    //         }
                                    //         if(int.Parse(parsedDate[1]) < 1900 || int.Parse(parsedDate[1]) > 2023){
                                    //             continueLoop = true;
                                    //             break;
                                    //         }
                                    //     }

                                    // }
                                    // if(continueLoop){
                                    //     System.Console.WriteLine("Please enter a valid date.");
                                    //     continue;
                                    // }


                                }
                                if (stayInCase == false)
                                {
                                    break;
                                }
                                (bool, string) claimExit;
                                while (true)
                                {
                                    System.Console.WriteLine("Press \"esc\" key anytime to return to menu.\n");
                                    System.Console.WriteLine("Please enter the Claim Date, in 00/00/0000 format, where order is month/day/year :\n");
                                    claimExit = checkEscKey();
                                    System.Console.WriteLine("\n");

                                    if (claimExit.Item1 == true)
                                    {
                                        stayInCase = false;
                                        break;
                                    }
                                    if (DateTime.TryParse(claimExit.Item2, out _) == false)
                                    {
                                        System.Console.WriteLine("Please enter a valid date.\n");
                                        continue;
                                    }

                                    else
                                    {
                                        break;
                                    }



                                }
                                if (stayInCase == false)
                                {
                                    break;

                                }
                                DateTime incidentObj = DateTime.Parse(incidentExit.Item2);
                                DateTime claimObj = DateTime.Parse(claimExit.Item2);

                                InsuranceClaimTicketClass counterTicket = new InsuranceClaimTicketClass(claimTypeExit.Item2, descriptionExit.Item2, claimAmountExit.Item2, incidentObj, claimObj);
                                if (counterTicket.getIsValid() == false)
                                {
                                    System.Console.WriteLine("Claim not accepted, dates between incident and claim are not possible or beyond 30 days.\n");
                                    break;
                                }
                                mainQueueRepo.addNewClaim(counterTicket);
                                System.Console.WriteLine("New Claim Ticket added!\n");
                                break;

                            }
                            break;
                        }
                    // View next claim
                    case "2":
                        {
                            if (mainQueueRepo.getQueueRepo().Count == 0)
                            {
                                System.Console.WriteLine("There are no available claims.\n");
                                break;

                            }
                            System.Console.WriteLine("Here is the next claim.\n");
                            System.Console.WriteLine($"Claim Type: {mainQueueRepo.seeNextTicket().getClaimType()}\n" +
                                                     $"Description: {mainQueueRepo.seeNextTicket().getDescription()}\n" +
                                                     $"Claim Amount: {mainQueueRepo.seeNextTicket().getClaimAmount()}\n" +
                                                     $"Date of Incidence: {mainQueueRepo.seeNextTicket().getDateOfIncident()}\n" +
                                                     $"Date of Claim: {mainQueueRepo.seeNextTicket().getDateOfClaim()}\n");
                            break;
                        }
                    //See a list of all claims
                    case "3":
                        {
                            if (mainQueueRepo.getQueueRepo().Count == 0)
                            {
                                System.Console.WriteLine("There are no available claims.\n");
                                break;

                            }
                            List<InsuranceClaimTicketClass> myList = mainQueueRepo.listOfTickets();
                            int counter = 1;
                            foreach (InsuranceClaimTicketClass member in myList)
                            {
                                System.Console.WriteLine($"{counter}.\n");
                                System.Console.WriteLine($"Claim Type: {member.getClaimType()}\n" +
                                                         $"Description: {member.getDescription()}\n" +
                                                         $"Claim Amount: {member.getClaimAmount()}\n" +
                                                         $"Date of Incidence: {member.getDateOfIncident()}\n" +
                                                         $"Date of Claim: {member.getDateOfClaim()}\n");
                                counter++;
                            }


                            break;
                        }
                    //Process claims(remove them)
                    case "4":
                        {
                            if (mainQueueRepo.getQueueRepo().Count == 0)
                            {
                                System.Console.WriteLine("There are no available claims.\n");
                                break;

                            }
                            mainQueueRepo.processTicket();
                            System.Console.WriteLine("Next Claim has been processed.");
                            break;
                        }
                    //Exit
                    case "5":
                        {
                            exitProgram = true;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }
        public (bool, string) checkEscKey()
        {
            bool wantToGetOut = false;
            string wordsTyped = "";
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                ConsoleKeyInfo singleChar = Console.ReadKey(true);

                if (singleChar.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Escape key pressed. Going to previous menu...");
                    wantToGetOut = true;
                    break;
                }
                if (singleChar.Key == ConsoleKey.Enter)
                {
                    wordsTyped = sb.ToString();
                    sb.Clear();
                    break;
                }
                if (singleChar.Key == ConsoleKey.Backspace)
                {
                    if (sb.Length > 0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                        Console.Write("\b \b"); // erase the last character from the console
                    }
                }
                else
                {
                    sb.Append(singleChar.KeyChar);
                    Console.Write(singleChar.KeyChar);
                }
            }
            return (wantToGetOut, wordsTyped);

        }



    }
}