using Microsoft.Extensions.Configuration;
using NLog;
using StackExchange.Redis;

namespace RepositoryLayer.Service
{
    public class RedisCacheService
    {
        private readonly ConnectionMultiplexer _redis;
        private readonly IDatabase _cache;
        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        public RedisCacheService(IConfiguration configuration)
        {
            string redisConnection = configuration["Redis:ConnectionString"];
            _redis = ConnectionMultiplexer.Connect(redisConnection);
            _cache = _redis.GetDatabase();
        }

        public void SetCache(string key, string value)
        {
            try
            {
                logger.Info("Setting cache for key");
                _cache.StringSet(key, value, TimeSpan.FromMinutes(10));  // Cache for 10 minutes
            }
            catch (Exception ex)
            {
                {
                    logger.Error("Error setting cache");
                    throw new Exception(ex.Message);
                }
            }
        }

        public string GetCache(string key)
        {
            try
            {
                logger.Info("Getting cache for key");
                return _cache.StringGet(key);
            }
            catch (Exception ex)
            {
                logger.Error("Error getting cache");
                throw new Exception(ex.Message);
            }
        }

        public void RemoveCache(string key)
        {
            try
            {
                logger.Info("Removing cache for key");
                _cache.KeyDelete(key);
            }
            catch (Exception ex)
            {
                logger.Error("Error removing cache");
                throw new Exception(ex.Message);
            }
        }
    }
}
