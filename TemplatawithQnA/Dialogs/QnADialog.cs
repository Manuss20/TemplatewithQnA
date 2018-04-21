using System;
using System.Threading.Tasks;
using System.Linq;
using System.Configuration;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;

namespace TemplatewithQnA.Dialogs
{
    [Serializable]
    public class QnaDialog : QnAMakerDialog
    {
        public QnaDialog() : base(new QnAMakerService(new
            QnAMakerAttribute(ConfigurationManager.AppSettings["QnaSubscriptionKey"],
            ConfigurationManager.AppSettings["QnaKnowledgebaseId"], "Sorry, I couldn't find an answer for that", 0.5)))
        {
        }
    }
}