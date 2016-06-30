using AlexaSkillsKit.Speechlet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlexaSkillsKit.Authentication;
using AlexaSkillsKit.Json;
using AlexaSkillsKit.Slu;
using AlexaSkillsKit.UI;

namespace BmwApi.Web.Alexa
{
    public class AlexaRequest : Speechlet
    {
        private SpeechletResponse GetWelcomeResponse()
        {
            string speechOutput =
                "What would you like to know about your BMW?";

            return BuildSpeechletResponse("Welcome", speechOutput, false);
        }

        private SpeechletResponse GetChargingState(Intent intent, Session session)
        {
            var status = BmwApi.Core.Get.Status;
            Dictionary<string, Slot> slots = intent.Slots;

            string speechOutput = "";
            speechOutput = String.Format(
                "Your BMW's battery level is {0}% and it {1} ", status.ChargingLevelHv, GetChargindResponse(status));

            return BuildSpeechletResponse(intent.Name, speechOutput, true);
        }

        private object GetChargindResponse(BmwApi.Core.Model.ApiVehicleStatus status)
        {
            if (status.ChargingStatus.Equals("CHARGING"))
            {
                return string.Format("is charging. {0}", GetCompletionTime(status));
            }
            else if (status.ChargingStatus.Equals("FINISHED_FULLY_CHARGED"))
            {
                return "has fully charged";
            }
            else if (status.ChargingStatus.Equals("FINISHED_NOT_FULL"))
            {
                return "has finished charging";
            }
            else if (status.ChargingStatus.Equals("WAITING_FOR_CHARGING"))
            {
                return "is waiting to start charging";
            }
            else
            {
                return "is not charging";
            }
        }

        private string GetCompletionTime(BmwApi.Core.Model.ApiVehicleStatus status)
        {
            var tz = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            var newDate = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.Utc, tz);

            var completionTime = newDate.AddMinutes(status.ChargingTimeRemaining);
            return string.Format("It will complete in {0} minutes at {1}", status.ChargingTimeRemaining, completionTime.ToShortTimeString());
        }

        private SpeechletResponse BuildSpeechletResponse(string title, string output, bool shouldEndSession)
        {
            SimpleCard card = new SimpleCard();
            card.Title = "BMW Charging State";
            card.Content = output;

            PlainTextOutputSpeech speech = new PlainTextOutputSpeech();
            speech.Text = output;

            SpeechletResponse response = new SpeechletResponse();
            response.ShouldEndSession = shouldEndSession;
            response.OutputSpeech = speech;
            response.Card = card;
            return response;
        }

        public override SpeechletResponse OnIntent(IntentRequest intentRequest, Session session)
        {
            return GetChargingState(intentRequest.Intent, session);
        }

        public override SpeechletResponse OnLaunch(LaunchRequest launchRequest, Session session)
        {
            return GetWelcomeResponse();
        }

        public override void OnSessionStarted(SessionStartedRequest sessionStartedRequest, Session session)
        {
        }

        public override void OnSessionEnded(SessionEndedRequest sessionEndedRequest, Session session)
        {
        }
    }
}