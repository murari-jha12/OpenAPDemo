namespace BlazorApp.CodeReviewer
{
    public class ChatGptAddSummary
    {
        /// <summary>
        /// Checks the age of the passenger and checks whether they are an adult or an infant. 
        /// </summary>
        /// <param name="age">Age of the passenger</param>
        /// <returns>Whether the passenger is an adult or infant.</returns> 
        public string CheckPassenger(int age)
        {
            if (age > 2)
            {
                return "Adult";
            }
            else
            {
                return "Infant";
            }

        }
        /// <summary>
        /// This method is used to check if a person is eligible to vote for an election.
        /// </summary>
        /// <param name="age">The age of the person.</param>
        /// <returns>True if the person is eligible, else False.</returns>
        public bool VoterEligibility(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
