using Azure;
using Azure.AI.TextAnalytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_TextAnalytics
{
    public class TextAnalytics
    {
        #region [Constructor]
        
        public TextAnalytics()
        {
            this.textAnalyticsClient = new TextAnalyticsClient(uri, azureKeyCredential);
        }

        #endregion

        #region [Public Properties]

        public AzureKeyCredential AzureKeyCredential
        {
            get
            {
                return azureKeyCredential;
            }
        }

        public Uri Uri 
        {
            get
            {
                return uri;
            }
        }
        
        public TextAnalyticsClient TextAnalyticsClient 
        {
            get
            {
                return textAnalyticsClient;
            }
        }

        #endregion

        #region [Private Fields]

        private AzureKeyCredential azureKeyCredential = new AzureKeyCredential("EKF7OyYzDDAh0aEUNk7byQRtoEukdzX3qy2GbJ22s4MYW9FGTrE2JQQJ99BDACYeBjFXJ3w3AAAaACOGmVut");
        private Uri uri = new Uri("https://ai-102-text-analytics.cognitiveservices.azure.com/");
        private TextAnalyticsClient textAnalyticsClient;

        #endregion

        #region [Public Methods]
        
        public string SentimentAnalysis(string inputText)
        {
            DocumentSentiment documentSentiment = textAnalyticsClient.AnalyzeSentiment(inputText);
            ////documentSentiment.Sentences.ToList().ForEach(sentence =>
            ////{
            ////    Console.WriteLine($"Text: {sentence.Text}");
            ////    Console.WriteLine($"Sentiment: {sentence.Sentiment}");
            ////    Console.WriteLine($"Positive Score: {sentence.ConfidenceScores.Positive}");
            ////    Console.WriteLine($"Neutral Score: {sentence.ConfidenceScores.Neutral}");
            ////    Console.WriteLine($"Negative Score: {sentence.ConfidenceScores.Negative}");
            ////});
            StringBuilder overallSentiment = new StringBuilder();
            overallSentiment.AppendLine($"Overall Sentiment: {documentSentiment.Sentiment}");
            overallSentiment.AppendLine($"Positive Score: {documentSentiment.ConfidenceScores.Positive}");
            overallSentiment.AppendLine($"Neutral Score: {documentSentiment.ConfidenceScores.Neutral}");
            overallSentiment.AppendLine($"Negative Score: {documentSentiment.ConfidenceScores.Negative}");
            
            return overallSentiment.ToString();
        }

        public string KeyPhraseExtraction(string inputText)
        {
            KeyPhraseCollection keyPhrases = textAnalyticsClient.ExtractKeyPhrases(inputText);
            ////foreach (string keyPhrase in keyPhrases)
            ////{
            ////    Console.WriteLine($"Key Phrase: {keyPhrase}");
            ////}
            return string.Join(", ", keyPhrases);
        }

        #endregion
    }
}
