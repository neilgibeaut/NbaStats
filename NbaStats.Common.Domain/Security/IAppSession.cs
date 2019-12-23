using System;

namespace NbaStats.Common.Domain
{
    public class IAppSession
    {
        Guid UserGuid { get; set; }

        Guid SessionId { get; set; }

        string UserName { get; set; }
    }
}
