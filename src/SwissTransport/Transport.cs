﻿using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query+"&type=station");//
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var message = new StreamReader(responseStream).ReadToEnd();
                var stations = JsonConvert.DeserializeObject<Stations>(message
                    , new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                return stations;
            }

            return null;
        }

        public StationBoardRoot GetStationBoard(string station, string id, string datetime=null)
        {
            var request = CreateWebRequest(string.IsNullOrWhiteSpace(datetime)? "http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id :
                "http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id + "&datetime=" + datetime);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }

        public Connections GetConnections(string fromStation, string toStation, string date=null, string time=null)
        {
            var request = CreateWebRequest(string.IsNullOrEmpty(date) || string.IsNullOrEmpty(time)? "http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStation 
                :"http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStation + "&date=" + date + "&time=" + time + "&limit=5");
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
                return connections;
            }

            return null;
        }
        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }
    }
}
