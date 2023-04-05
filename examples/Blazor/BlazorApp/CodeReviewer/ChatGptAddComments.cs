namespace BlazorApp.CodeReviewer
{
    public class ChatGptAddComments
    {
        //This  function checks the age of a passenger and returns a corresponding string value indicating whether they are an adult or infant
        public string CheckPassenger(int age)
        {
            //Check if age is greater than 2
            if (age > 2)
            {
                //If greater than 2, return the string "Adult"
                return "Adult";
            }
            else
            {
                //If not greater than 2, return the string "Infant"
                return "Infant";
            }

        }

        // Rewritten code
        public bool VoterEligibility(int age)
        {
            // Checks if the user is age 18 or over 
            // and returns a boolean result
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
