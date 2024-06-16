using System.Text.Json;
using BizHawk.Client.Common;
using MetroidFusionExtractor.Memory.Global.RAM;

namespace MetroidFusionExtractor.Player
{
    public class PlayerData
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public int VelocityX { get; private set; }
        public int VelocityY { get; private set; } //164 when jumping (base)
        
        public int AccelerationX { get; private set; }
        public int AccelerationY { get; private set; }


        public PlayerData(IMemoryApi memoryApi)
        {
            PositionX = memoryApi.ReadS16(Address.XPosition);
            PositionY = memoryApi.ReadS16(Address.YPosition);

            VelocityX = memoryApi.ReadS16(Address.XVelocity);
            VelocityY = memoryApi.ReadS16(Address.YVelocity);

            AccelerationX = memoryApi.ReadS16(Address.XAcceleration);
            AccelerationY = memoryApi.ReadS16(Address.YAcceleration);
        }
    }
}