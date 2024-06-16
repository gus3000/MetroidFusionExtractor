namespace MetroidFusionExtractor.Memory
{
    namespace Global
    {
        namespace RAM
        {
            public abstract class Address
            {
                public const long XPosition = 0x300125A; // quarter pixel
                public const long YPosition = 0x300125C; // quarter pixel

                public const long XVelocity = 0x300125E; //32ths of a pixel
                public const long YVelocity = 0x3001260; //32ths of a pixel

                public const long XAcceleration = 0x300133C;
                public const long YAcceleration = 0x3001332;
                
                public const long Previous64XPositions = 0x300134C;
                public const long Previous64YPositions = 0x30013CC;
            }
        }
    }
}