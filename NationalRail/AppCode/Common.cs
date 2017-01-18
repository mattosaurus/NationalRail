using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NationalRail.Models.HistoricalServicePerformance;
using System.Globalization;

namespace NationalRail.AppCode
{
    public class Common
    {
        public static string EncodeBas64String(string textToBeEncoded)
        {
            string encodedText;

            byte[] bytesToBeEncoded = System.Text.Encoding.UTF8.GetBytes(textToBeEncoded);
            encodedText = Convert.ToBase64String(bytesToBeEncoded);

            return encodedText;
        }

        public static string DecodeBas64String(string textToBeDecoded)
        {
            string decodedText;

            byte[] bytesToBeDecoded = Convert.FromBase64String(textToBeDecoded);
            decodedText = System.Text.Encoding.UTF8.GetString(bytesToBeDecoded);

            return decodedText;
        }

        public static int GetDelayMinutes(ServiceDetailsLocation location, string dateOfService)
        {
            // If depature or arrival time is not provided assume happened at the same time
            if(location.ActualTimeOfDeparture == "")
            {
                location.ActualTimeOfDeparture = location.ActualTimeOfArrival;
            }

            if (location.ActualTimeOfArrival == "")
            {
                location.ActualTimeOfArrival = location.ActualTimeOfDeparture;
            }

            if (location.PredictedTimeOfDeparture == "")
            {
                location.PredictedTimeOfDeparture = location.PredictedTimeOfArrival;
            }

            if (location.PredictedTimeOfArrival == "")
            {
                location.PredictedTimeOfArrival = location.PredictedTimeOfDeparture;
            }

            DateTime predictedDepartureTime = DateTime.ParseExact(dateOfService + " " + location.PredictedTimeOfDeparture, "yyyy-MM-dd HHmm", CultureInfo.InvariantCulture);
            DateTime actualDepartureTime = DateTime.ParseExact(dateOfService + " " + location.ActualTimeOfDeparture, "yyyy-MM-dd HHmm", CultureInfo.InvariantCulture);

            // Fix to cope with midnight given only day given for departure from first station
            // Could potentially fail if departs earlier than predicted
            if(location.ActualTimeOfDeparture.StartsWith("0") && location.PredictedTimeOfDeparture.StartsWith("2"))
            {
                actualDepartureTime = actualDepartureTime.AddDays(1);
            }

            TimeSpan delayTimeSpan = actualDepartureTime.Subtract(predictedDepartureTime);
            int delayMinutes = delayTimeSpan.Minutes;

            return delayMinutes;
        }
    }
}
