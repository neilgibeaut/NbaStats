using System;

namespace NbaStats.Domain.Security
{
    public class IAppSession
    {
        Guid UserGuid { get; set; }

        Guid SessionId { get; set; }
    }
}
