using AI_TextAnalytics;

class Program
{
    public static string inputText =
        "Unlike most of our gadgets, life doesn’t come with a How-To guide, or a Fix-It manual to download. But we can find solace in the wisdom and experiences of those who walked before us, such as Aristotle and Socrates.";
    //"I had a lovely day today, the breeze was so soft and calm.";

    // This is the main entry point for the application.
    static void Main(string[] args)
    {

        // Print the input text to analyze.
        Console.WriteLine("Input to analyze: {0}", inputText);

        // Create an instance of the TextAnalytics class.
        TextAnalytics textAnalytics = new TextAnalytics();

        // Call the SentimentAnalysis method and print the result.
        string sentimentResult = textAnalytics.SentimentAnalysis(inputText);

        // Print the sentiment analysis result.
        Console.WriteLine("\n\n\nOverall Sentiment: {0}", sentimentResult);

        // Call the KeyPhraseExtraction method and print the result.
        string keyPhrase = textAnalytics.KeyPhraseExtraction(inputText);

        // Print the key phrase extraction result.
        Console.WriteLine("\nKeyphrases: {0}", keyPhrase);
    }
}