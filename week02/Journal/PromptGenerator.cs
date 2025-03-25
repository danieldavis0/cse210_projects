public class PromptGenerator
{
    
    public List<string> _prompts = new List<string>(["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "Whose life did I positively affect today?", "How satisfied am I with how my day went?"]);

    public string GetRandomPrompt(string mostRecentPrompt)
    {
        Random random = new Random();
        int lengthOfList = _prompts.Count();
        long randomNumber = random.NextInt64(lengthOfList);
        int promptNumber = Convert.ToInt32(randomNumber);
        string newPrompt = _prompts[promptNumber];

        if (newPrompt == mostRecentPrompt)
        {
            while (newPrompt == mostRecentPrompt)
            {
                randomNumber = random.NextInt64(lengthOfList);
                promptNumber = Convert.ToInt32(randomNumber);
                newPrompt = _prompts[promptNumber];
            }
        }

        mostRecentPrompt = newPrompt;

        return newPrompt;
    }
}

