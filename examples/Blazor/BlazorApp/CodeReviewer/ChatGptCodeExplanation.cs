namespace BlazorApp.CodeReviewer
{
    public class ChatGptCodeExplanation
    {



        //This function is used to check the age of a passenger and return a value depending on the age.
        //If the age of the passenger is greater  than two, it will return "Adult", and if the age is two or younger,
        //it will return "Infant".
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



        //This function checks if a person is eligible to vote in an election or referendum.
        //It takes one parameter, age, and checks if it is greater or equal to 18. If it is,
        //then it returns true, meaning the person is eligible to vote.Otherwise,
        //it returns false meaning the person is not eligible to vote.
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
