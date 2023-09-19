using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.CoreErpModel
{
    public partial class SignalRChatDetail
    {
        public int ChatId { get; set; }
        public int? FromUserId { get; set; }
        public int? ToUserId { get; set; }
        public string ChatMessage { get; set; }
        public DateTime? MessageTime { get; set; }
    }
}
