namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id=null, string datetime=null);
        Connections GetConnections(string fromStation, string toStation, string date = null, string time = null);
    }
}