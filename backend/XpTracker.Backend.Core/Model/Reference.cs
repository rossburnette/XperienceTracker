﻿using XpTracker.Backend.Core.Model.Common;

namespace XpTracker.Backend.Core.Model
{
    /// <summary>
    /// A reference represents a person to contact to verify the experience
    /// </summary>
    internal class Reference : AuditableEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
    }
}