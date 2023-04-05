namespace BlazorApp.CodeReviewer
{
    public class ChatGptBugIndication
    {
        public string CheckPassenger(int age)
        {
            if (age > 2)
            {
                return "Adult";
            }
            else
            {
                return "Infant"; //false;
            }

        }

        //The return  type of this function should be a string, not a boolean, so this line should be changed to: return "Infant";



        public bool VoterEligibility(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;//"test";
            }

        }


        //Bug: The method should return a boolean value rather than a string.
    }
}
