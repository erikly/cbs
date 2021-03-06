using Concepts;
using System;

namespace Read.AutomaticReplyMessages
{
    public class DefaultAutomaticReplyKeyMessage
    {
        public DefaultAutomaticReplyKeyMessage(Guid id) => Id = id;
        public Guid Id { get; set; }
        public Guid HealthRiskId { get; set; }
        public AutomaticReplyKeyMessageType Type { get; set; }
        public string Message { get; set; }
        public string Language { get; set; }
    }
}