using ArangoDBNetStandard;
using ArangoDBNetStandard.Transport.Http;
public class ArangoCatDb : ICatDb
{
    private ArangoDBClient adb;
    public ArangoCatDb()
    {
        var ArangoPass = Environment.GetEnvironmentVariable("ARANGO_ROOT_PASSWORD");
        var Transport = HttpApiTransport.UsingBasicAuth(new Uri("http://localhost:8529/"), "_system", "root", ArangoPass);
        adb = new ArangoDBClient(Transport);
    }
    public async Task<IEnumerable<CatFact>> GetCatFacts()
    {
        return (await adb.Cursor.PostCursorAsync<CatFact>("FOR doc IN catFacts RETURN doc")).Result;
    }
}