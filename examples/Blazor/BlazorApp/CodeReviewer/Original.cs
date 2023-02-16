namespace BlazorApp.CodeReviewer
{
    public class Original
    {
        public string CheckPassenger(int age)
        {
            if(age>2)
            {
                return "Adult";
            }
            else
            {
                return "Infant";
            }

        }

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
