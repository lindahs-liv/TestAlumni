using System;

namespace BusinessEntities
{
    public interface IActivity
    {
        string ActivityName { get; set; }
        string Details { get; set; }
        DateTime SetDate { get; set; }
    }
}