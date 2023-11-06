namespace ReworkedOOPGenericCollections.Logic
{
    public class ExceptionHelper
    {
        public static void ExceptionDetails(Exception ex)
        {
            if (PromptForYesOrNo("See detailed error message? (Y)es or (N)o: "))
            {
                Console.WriteLine($"Error Message: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"Help Link: {ex.HelpLink}");
            }
            else
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        private static bool PromptForYesOrNo(string prompt = "Answer (Y)es or (N)o: ", string errorMessage = "Invalid input. Answer must be (Y)es or (N)o.")
        {
            while (true)
            {
                Console.Write(prompt);
                string userInput = Console.ReadLine().ToUpper();
                if (userInput == "YES" || userInput == "YE" || userInput == "Y" || userInput == "JA" || userInput == "J")
                {
                    return true;
                }
                if (userInput == "NO" || userInput == "N" || userInput == "NE" || userInput == "NEJ")
                {
                    return false;
                }

                Console.WriteLine(errorMessage);
            }
        }
    }
}
