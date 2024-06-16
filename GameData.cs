using System.Text.Json;
using BizHawk.Client.Common;
using MetroidFusionExtractor.Player;

namespace MetroidFusionExtractor
{
    public class GameData
    {
        public string debugValue { get; private set; }
        public PlayerData PlayerData { get; private set; }

        public GameData(IMemoryApi memoryApi)
        {
            var oldDomain = memoryApi.GetCurrentMemoryDomain();

            PlayerData = new PlayerData(memoryApi);
            debugValue = "14";

            memoryApi.UseMemoryDomain(oldDomain);
        }
        
        public string Serialize()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            return JsonSerializer.Serialize(this, options);
        }
    }
}