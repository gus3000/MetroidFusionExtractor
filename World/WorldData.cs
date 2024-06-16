using BizHawk.Client.Common;

namespace MetroidFusionExtractor.World
{
    public class WorldData
    {
        public WorldData(IMemoryApi memoryApi)
        {
            var oldDomain = memoryApi.GetCurrentMemoryDomain();
            memoryApi.UseMemoryDomain("ROM");
            
            
            
            
            memoryApi.UseMemoryDomain(oldDomain);
        }
    }
}