using NationalRail.Models.LiveDepartureBoard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NationalRail
{
    public class LiveDepartureBoardClient
    {
        private readonly string _token;
        private readonly string _url = "https://lite.realtime.nationalrail.co.uk/OpenLDBWS/ldb9.asmx";

        public LiveDepartureBoardClient(string token)
        {
            _token = token;
        }

        /// <summary>
        /// Returns all public departures for the supplied CRS code within a defined time window.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<DepartureBoardResponse.Envelope> GetDepartureBoard(DepartureBoardRequest.Body body)
        {
            DepartureBoardRequest.Envelope envelope = new DepartureBoardRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = body;

            XmlSerializer serializer = new XmlSerializer(envelope.GetType());

            using (StringWriter stringWriter = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    serializer.Serialize(xmlWriter, envelope);

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));//ACCEPT header

                        StringContent content = new StringContent(stringWriter.ToString());
                        content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("text/xml");
                        HttpResponseMessage response = await client.PostAsync(new Uri(_url), content);

                        response.EnsureSuccessStatusCode();

                        XmlSerializer resultSerializer = new XmlSerializer(typeof(DepartureBoardResponse.Envelope));
                        DepartureBoardResponse.Envelope stationBoard = (DepartureBoardResponse.Envelope)resultSerializer.Deserialize(await response.Content.ReadAsStreamAsync());

                        return stationBoard;
                    }
                }
            }
        }

        /// <summary>
        /// Returns all public arrivals and departures for the supplied CRS code within a defined time window, including service details.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<ArrivalBoardDetailsResponse.Envelope> GetArrivalBoardWithDetails(ArrivalBoardDetailsRequest.Body body)
        {
            ArrivalBoardDetailsRequest.Envelope envelope = new ArrivalBoardDetailsRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = body;

            XmlSerializer serializer = new XmlSerializer(envelope.GetType());

            using (StringWriter stringWriter = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    serializer.Serialize(xmlWriter, envelope);

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));//ACCEPT header

                        StringContent content = new StringContent(stringWriter.ToString());
                        content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("text/xml");
                        HttpResponseMessage response = await client.PostAsync(new Uri(_url), content);

                        response.EnsureSuccessStatusCode();

                        XmlSerializer resultSerializer = new XmlSerializer(typeof(ArrivalBoardDetailsResponse.Envelope));
                        ArrivalBoardDetailsResponse.Envelope stationBoard = (ArrivalBoardDetailsResponse.Envelope)resultSerializer.Deserialize(await response.Content.ReadAsStreamAsync());

                        return stationBoard;
                    }
                }
            }
        }

        /// <summary>
        /// Returns all public arrivals and departures for the supplied CRS code within a defined time window, including service details.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<ArrivalDepartureBoardDetailsResponse.Envelope> GetArrivalDepartureBoardWithDetails(ArrivalDepartureBoardDetailsRequest.Body body)
        {
            ArrivalDepartureBoardDetailsRequest.Envelope envelope = new ArrivalDepartureBoardDetailsRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = body;

            XmlSerializer serializer = new XmlSerializer(envelope.GetType());

            using (StringWriter stringWriter = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    serializer.Serialize(xmlWriter, envelope);

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));//ACCEPT header

                        StringContent content = new StringContent(stringWriter.ToString());
                        content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("text/xml");
                        HttpResponseMessage response = await client.PostAsync(new Uri(_url), content);

                        response.EnsureSuccessStatusCode();

                        XmlSerializer resultSerializer = new XmlSerializer(typeof(ArrivalDepartureBoardDetailsResponse.Envelope));
                        ArrivalDepartureBoardDetailsResponse.Envelope stationBoard = (ArrivalDepartureBoardDetailsResponse.Envelope)resultSerializer.Deserialize(await response.Content.ReadAsStreamAsync());

                        return stationBoard;
                    }
                }
            }
        }

        /// <summary>
        /// Returns all public arrivals and departures for the supplied CRS code within a defined time window.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<ArrivalBoardResponse.Envelope> GetArrivalBoard(ArrivalBoardRequest.Body body)
        {
            ArrivalBoardRequest.Envelope envelope = new ArrivalBoardRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = body;

            XmlSerializer serializer = new XmlSerializer(envelope.GetType());

            using (StringWriter stringWriter = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    serializer.Serialize(xmlWriter, envelope);

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));//ACCEPT header

                        StringContent content = new StringContent(stringWriter.ToString());
                        content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("text/xml");
                        HttpResponseMessage response = await client.PostAsync(new Uri(_url), content);

                        response.EnsureSuccessStatusCode();

                        XmlSerializer resultSerializer = new XmlSerializer(typeof(ArrivalBoardResponse.Envelope));
                        ArrivalBoardResponse.Envelope stationBoard = (ArrivalBoardResponse.Envelope)resultSerializer.Deserialize(await response.Content.ReadAsStreamAsync());

                        return stationBoard;
                    }
                }
            }
        }

        /// <summary>
        /// Returns all public arrivals and departures for the supplied CRS code within a defined time window.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<ArrivalDepartureBoardResponse.Envelope> GetArrivalDepartureBoard(ArrivalDepartureBoardRequest.Body body)
        {
            ArrivalDepartureBoardRequest.Envelope envelope = new ArrivalDepartureBoardRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = body;

            XmlSerializer serializer = new XmlSerializer(envelope.GetType());

            using (StringWriter stringWriter = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    serializer.Serialize(xmlWriter, envelope);

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));//ACCEPT header

                        StringContent content = new StringContent(stringWriter.ToString());
                        content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("text/xml");
                        HttpResponseMessage response = await client.PostAsync(new Uri(_url), content);

                        response.EnsureSuccessStatusCode();

                        XmlSerializer resultSerializer = new XmlSerializer(typeof(ArrivalDepartureBoardResponse.Envelope));
                        ArrivalDepartureBoardResponse.Envelope stationBoard = (ArrivalDepartureBoardResponse.Envelope)resultSerializer.Deserialize(await response.Content.ReadAsStreamAsync());

                        return stationBoard;
                    }
                }
            }
        }

        /// <summary>
        /// Returns all public departures for the supplied CRS code within a defined time window, including service details.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<DepartureBoardDetailsResponse.Envelope> GetDepartureBoardWithDetails(DepartureBoardDetailsRequest.Body body)
        {
            DepartureBoardDetailsRequest.Envelope envelope = new DepartureBoardDetailsRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = body;

            XmlSerializer serializer = new XmlSerializer(envelope.GetType());

            using (StringWriter stringWriter = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    serializer.Serialize(xmlWriter, envelope);

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));//ACCEPT header

                        StringContent content = new StringContent(stringWriter.ToString());
                        content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("text/xml");
                        HttpResponseMessage response = await client.PostAsync(new Uri(_url), content);

                        response.EnsureSuccessStatusCode();

                        XmlSerializer resultSerializer = new XmlSerializer(typeof(DepartureBoardDetailsResponse.Envelope));
                        DepartureBoardDetailsResponse.Envelope stationBoard = (DepartureBoardDetailsResponse.Envelope)resultSerializer.Deserialize(await response.Content.ReadAsStreamAsync());

                        return stationBoard;
                    }
                }
            }
        }

        /// <summary>
        /// Returns the public departure for the supplied CRS code within a defined time window to the locations specified in the filter with the earliest arrival time at the filtered location.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<FastestDepartureResponse.Envelope> GetFastestDepartures(FastestDepartureRequest.Body body)
        {
            FastestDepartureRequest.Envelope envelope = new FastestDepartureRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = body;

            XmlSerializer serializer = new XmlSerializer(envelope.GetType());

            using (StringWriter stringWriter = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    serializer.Serialize(xmlWriter, envelope);

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));//ACCEPT header

                        StringContent content = new StringContent(stringWriter.ToString());
                        content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("text/xml");
                        HttpResponseMessage response = await client.PostAsync(new Uri(_url), content);

                        response.EnsureSuccessStatusCode();

                        XmlSerializer resultSerializer = new XmlSerializer(typeof(FastestDepartureResponse.Envelope));
                        FastestDepartureResponse.Envelope stationBoard = (FastestDepartureResponse.Envelope)resultSerializer.Deserialize(await response.Content.ReadAsStreamAsync());

                        return stationBoard;
                    }
                }
            }
        }

        /// <summary>
        /// Returns the public departure for the supplied CRS code within a defined time window to the locations specified in the filter with the earliest arrival time at the filtered location, including service details.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<FastestDepartureDetailsResponse.Envelope> GetFastestDeparturesWithDetails(FastestDepartureDetailsRequest.Body body)
        {
            FastestDepartureDetailsRequest.Envelope envelope = new FastestDepartureDetailsRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = body;

            XmlSerializer serializer = new XmlSerializer(envelope.GetType());

            using (StringWriter stringWriter = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    serializer.Serialize(xmlWriter, envelope);

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));//ACCEPT header

                        StringContent content = new StringContent(stringWriter.ToString());
                        content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("text/xml");
                        HttpResponseMessage response = await client.PostAsync(new Uri(_url), content);

                        response.EnsureSuccessStatusCode();

                        XmlSerializer resultSerializer = new XmlSerializer(typeof(FastestDepartureDetailsResponse.Envelope));
                        FastestDepartureDetailsResponse.Envelope stationBoard = (FastestDepartureDetailsResponse.Envelope)resultSerializer.Deserialize(await response.Content.ReadAsStreamAsync());

                        return stationBoard;
                    }
                }
            }
        }

        /// <summary>
        /// Returns the next public departure for the supplied CRS code within a defined time window to the locations specified in the filter.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<NextDepartureResponse.Envelope> GetNextDeparture(NextDepartureRequest.Body body)
        {
            NextDepartureRequest.Envelope envelope = new NextDepartureRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = body;

            XmlSerializer serializer = new XmlSerializer(envelope.GetType());

            using (StringWriter stringWriter = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    serializer.Serialize(xmlWriter, envelope);

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));//ACCEPT header

                        StringContent content = new StringContent(stringWriter.ToString());
                        content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("text/xml");
                        HttpResponseMessage response = await client.PostAsync(new Uri(_url), content);

                        response.EnsureSuccessStatusCode();

                        XmlSerializer resultSerializer = new XmlSerializer(typeof(NextDepartureResponse.Envelope));
                        NextDepartureResponse.Envelope stationBoard = (NextDepartureResponse.Envelope)resultSerializer.Deserialize(await response.Content.ReadAsStreamAsync());

                        return stationBoard;
                    }
                }
            }
        }

        /// <summary>
        /// Returns the next public departure for the supplied CRS code within a defined time window to the locations specified in the filter, including service details.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<NextDepartureDetailsResponse.Envelope> GetNextDepartureWithDetails(NextDepartureDetailsRequest.Body body)
        {
            NextDepartureDetailsRequest.Envelope envelope = new NextDepartureDetailsRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = body;

            XmlSerializer serializer = new XmlSerializer(envelope.GetType());

            using (StringWriter stringWriter = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    serializer.Serialize(xmlWriter, envelope);

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));//ACCEPT header

                        StringContent content = new StringContent(stringWriter.ToString());
                        content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("text/xml");
                        HttpResponseMessage response = await client.PostAsync(new Uri(_url), content);

                        response.EnsureSuccessStatusCode();

                        XmlSerializer resultSerializer = new XmlSerializer(typeof(NextDepartureDetailsResponse.Envelope));
                        NextDepartureDetailsResponse.Envelope stationBoard = (NextDepartureDetailsResponse.Envelope)resultSerializer.Deserialize(await response.Content.ReadAsStreamAsync());

                        return stationBoard;
                    }
                }
            }
        }

        /// <summary>
        /// Returns service details for a specific service identified by a station board. These details are supplied relative to the station board from which the serviceID field value was generated. Service details are only available while the service appears on the station board from which it was obtained. This is normally for two minutes after it is expected to have departed, or after a terminal arrival. If a request is made for a service that is no longer available then a null value is returned.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<ServiceDetailsResponse.Envelope> GetServiceDetails(ServiceDetailsRequest.Body body)
        {
            ServiceDetailsRequest.Envelope envelope = new ServiceDetailsRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = body;

            XmlSerializer serializer = new XmlSerializer(envelope.GetType());

            using (StringWriter stringWriter = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    serializer.Serialize(xmlWriter, envelope);

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));//ACCEPT header

                        StringContent content = new StringContent(stringWriter.ToString());
                        content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("text/xml");
                        HttpResponseMessage response = await client.PostAsync(new Uri(_url), content);

                        response.EnsureSuccessStatusCode();

                        XmlSerializer resultSerializer = new XmlSerializer(typeof(ServiceDetailsResponse.Envelope));
                        ServiceDetailsResponse.Envelope stationBoard = (ServiceDetailsResponse.Envelope)resultSerializer.Deserialize(await response.Content.ReadAsStreamAsync());

                        return stationBoard;
                    }
                }
            }
        }
    }
}
