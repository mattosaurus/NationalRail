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

        public async Task<DepartureBoardResponse.Envelope> GetDepartureBoard(DepartureBoardRequest.Body departureBoardBody)
        {
            DepartureBoardRequest.Envelope envelope = new DepartureBoardRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = departureBoardBody;

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

        public async Task<ArrivalBoardDetailsResponse.Envelope> GetArrivalBoardWithDetails(ArrivalBoardDetailsRequest.Body arrivalBoardBody)
        {
            ArrivalBoardDetailsRequest.Envelope envelope = new ArrivalBoardDetailsRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = arrivalBoardBody;

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

        public async Task<ArrivalDepartureBoardDetailsResponse.Envelope> GetArrivalDepartureBoardWithDetails(ArrivalDepartureBoardDetailsRequest.Body arrivalBoardBody)
        {
            ArrivalDepartureBoardDetailsRequest.Envelope envelope = new ArrivalDepartureBoardDetailsRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = arrivalBoardBody;

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

        public async Task<ArrivalBoardResponse.Envelope> GetArrivalBoard(ArrivalBoardRequest.Body arrivalBoardBody)
        {
            ArrivalBoardRequest.Envelope envelope = new ArrivalBoardRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = arrivalBoardBody;

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

        public async Task<ArrivalDepartureBoardResponse.Envelope> GetArrivalDepartureBoard(ArrivalDepartureBoardRequest.Body arrivalBoardBody)
        {
            ArrivalDepartureBoardRequest.Envelope envelope = new ArrivalDepartureBoardRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = arrivalBoardBody;

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

        public async Task<DepartureBoardDetailsResponse.Envelope> GetDepartureBoardWithDetails(DepartureBoardDetailsRequest.Body arrivalBoardBody)
        {
            DepartureBoardDetailsRequest.Envelope envelope = new DepartureBoardDetailsRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = arrivalBoardBody;

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

        public async Task<FastestDepartureResponse.Envelope> GetFastestDepartures(FastestDepartureRequest.Body arrivalBoardBody)
        {
            FastestDepartureRequest.Envelope envelope = new FastestDepartureRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = arrivalBoardBody;

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

        public async Task<FastestDepartureDetailsResponse.Envelope> GetFastestDeparturesWithDetails(FastestDepartureDetailsRequest.Body arrivalBoardBody)
        {
            FastestDepartureDetailsRequest.Envelope envelope = new FastestDepartureDetailsRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = arrivalBoardBody;

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

        public async Task<NextDepartureResponse.Envelope> GetNextDeparture(NextDepartureRequest.Body arrivalBoardBody)
        {
            NextDepartureRequest.Envelope envelope = new NextDepartureRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = arrivalBoardBody;

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

        public async Task<NextDepartureDetailsResponse.Envelope> GetNextDepartureWithDetails(NextDepartureDetailsRequest.Body arrivalBoardBody)
        {
            NextDepartureDetailsRequest.Envelope envelope = new NextDepartureDetailsRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = arrivalBoardBody;

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

        public async Task<ServiceDetailsResponse.Envelope> GetServiceDetails(ServiceDetailsRequest.Body arrivalBoardBody)
        {
            ServiceDetailsRequest.Envelope envelope = new ServiceDetailsRequest.Envelope();
            envelope.Header.AccessToken.TokenValue = _token;
            envelope.Body = arrivalBoardBody;

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
