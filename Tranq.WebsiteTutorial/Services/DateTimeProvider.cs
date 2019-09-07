using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tranq.WebsiteTutorial.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
