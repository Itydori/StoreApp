using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StoreApp.Infrastructe.Extensions
{
    public static class SessionExtension
    {
        public static void SetJson(this ISession session, string key, object value)
        {

            session.SetString(key,JsonSerializer.Serialize(value));
        }
        public static void SetJson<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }
        public static T? GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null ? default : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}