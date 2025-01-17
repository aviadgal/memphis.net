﻿namespace Memphis.Client.Consumer
{
    #nullable disable
    public sealed class MemphisConsumerOptions
    {
        public string StationName { get; set; }
        public string ConsumerName { get; set; }
        public string ConsumerGroup { get; set; } = string.Empty;
        public int PullIntervalMs { get; set; } = 1_000;
        public int BatchSize { get; set; } = 10;
        public int BatchMaxTimeToWaitMs { get; set; } = 5_000;
        public int MaxAckTimeMs { get; set; } = 30_000;
        public int MaxMsdgDeliveries { get; set; } = 10;
        public bool GenerateUniqueSuffix { get; set; } = false;
        public int StartConsumeFromSequence { get; set; } = 0;
        public int LastMessages { get; set; } = -1;
        
        internal string RealName { get; set; }
    }
}