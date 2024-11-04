using MongoDB.Driver;

namespace CdpPsBackendDotnetTest.Utils.Mongo;

public interface IMongoDbClientFactory
{
    IMongoClient GetClient();

    IMongoCollection<T> GetCollection<T>(string collection);
}