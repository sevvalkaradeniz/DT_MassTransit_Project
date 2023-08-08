using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Model
{
    public class RabbitMQSettings
    {
        public const string PersonAddedCommandSendQueueName = "person-added-command-send-queue";

        public const string PersonAddedCommmandQueueName = "person-added-command-queue";

        public const string PersonDeletedCommandQueueName = "person-deleted-command-queue";

        public const string PersonUpdatedCommandQueueName = "person-updated-command-queue";
    }
}
