namespace _InsuranceUnitTesting;
using _InsuranceClaimTicketClass;
using _InsuranceClaimTicketRepo;
using _InsuranceClaimTicketUI;
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {   //Arrange
        DateTime dateIncident = new DateTime(2000, 3, 3);
        DateTime dateClaim = new DateTime(2000, 4, 3);

        InsuranceClaimTicketClass ticketObj = new InsuranceClaimTicketClass("Car", "something", "100", dateIncident, dateClaim);
        //Act

        string actual = ticketObj.getClaimType();
        string expected = "Car";

        //Assert
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void getExistingDescription_ShouldGetDescription()
    {
        //Arrange
        DateTime dateIncident = new DateTime(2000, 3, 3);
        DateTime dateClaim = new DateTime(2000, 4, 3);

        InsuranceClaimTicketClass ticketObj = new InsuranceClaimTicketClass("Car", "something", "100", dateIncident, dateClaim);
        //Act

        string actual = ticketObj.getDescription();
        string expected = "something";

        //Assert
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void getExistingClaimAmount_ShouldGetClaimAmount()
    {
        //Arrange
        DateTime dateIncident = new DateTime(2000, 3, 3);
        DateTime dateClaim = new DateTime(2000, 4, 3);

        InsuranceClaimTicketClass ticketObj = new InsuranceClaimTicketClass("Car", "something", "100", dateIncident, dateClaim);
        //Act

        string actual = ticketObj.getClaimAmount();
        string expected = "100";

        //Assert
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void getExistingDateOfIncident_ShouldGetDateOfIncident()
    {
        //Arrange
        DateTime dateIncident = new DateTime(2000, 3, 3);
        DateTime dateClaim = new DateTime(2000, 4, 3);

        InsuranceClaimTicketClass ticketObj = new InsuranceClaimTicketClass("Car", "something", "100", dateIncident, dateClaim);
        //Act
        DateTime dateOnly = dateIncident.Date;
        DateTime actual = ticketObj.getDateOfIncident();
        DateTime expected = dateOnly;

        //Assert
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void getExistingDateOfClaim_ShouldGetDateOfClaim()
    {
        //Arrange
        DateTime dateIncident = new DateTime(2000, 3, 3);
        DateTime dateClaim = new DateTime(2000, 4, 3);

        InsuranceClaimTicketClass ticketObj = new InsuranceClaimTicketClass("Car", "something", "100", dateIncident, dateClaim);
        //Act
        DateTime dateOnly = dateClaim.Date;
        DateTime actual = ticketObj.getDateOfClaim();
        DateTime expected = dateOnly;

        //Assert
        Assert.AreEqual(expected, actual);

    }

    //
    //
    //
    //
    //
    // TESTING FOR CRUD IN REPO
    //
    //
    //
    //
    //
    private InsuranceClaimTicketRepo repoObj = new InsuranceClaimTicketRepo();

    [TestMethod]
    public void addTicket_ShouldHaveTicketInRepo()
    {
        //Arrange
        DateTime dateIncident = new DateTime(2000, 3, 3);
        DateTime dateClaim = new DateTime(2000, 4, 3);

        InsuranceClaimTicketClass ticketObj = new InsuranceClaimTicketClass("Car", "something", "100", dateIncident, dateClaim);

        //Act
        repoObj.addNewClaim(ticketObj);


        //Assert
        Assert.IsNotNull(repoObj.getQueueRepo());

    }
    [TestMethod]
    public void removeTicket_ShouldHaveTicketRemovedFromRepo()
    {
        //Arrange
        DateTime dateIncident = new DateTime(2000, 3, 3);
        DateTime dateClaim = new DateTime(2000, 4, 3);

        InsuranceClaimTicketClass ticketObj = new InsuranceClaimTicketClass("Car", "something", "100", dateIncident, dateClaim);

        //Act
        repoObj.addNewClaim(ticketObj);
        repoObj.processTicket();


        //Assert
        Assert.IsNotNull(repoObj.getQueueRepo());
        Assert.AreEqual(0, repoObj.getQueueRepo().Count);

    }

    [TestMethod]
    public void getExisintList_ShouldGetNonEmptyList_AndOfTypeList()
    {

        DateTime dateIncident = new DateTime(2000, 3, 3);
        DateTime dateClaim = new DateTime(2000, 4, 3);

        InsuranceClaimTicketClass ticketObj = new InsuranceClaimTicketClass("Car", "something", "100", dateIncident, dateClaim);

        //Act
        repoObj.addNewClaim(ticketObj);



        //Assert
        Assert.IsNotNull(repoObj.listOfTickets());
        Assert.IsInstanceOfType(repoObj.listOfTickets(), typeof(List<InsuranceClaimTicketClass>));

    }
    [TestMethod]
    public void getNextItem_ShouldGetNextItem()
    {
        DateTime dateIncident = new DateTime(2000, 3, 3);
        DateTime dateClaim = new DateTime(2000, 4, 3);

        InsuranceClaimTicketClass ticketObj = new InsuranceClaimTicketClass("Car", "something", "100", dateIncident, dateClaim);

        //Act
        repoObj.addNewClaim(ticketObj);
        InsuranceClaimTicketClass actual = repoObj.seeNextTicket();
        InsuranceClaimTicketClass expected = ticketObj;



        //Assert
        Assert.AreEqual(expected, actual);
    }

}