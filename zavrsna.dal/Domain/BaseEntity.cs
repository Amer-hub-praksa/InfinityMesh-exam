using System;
using System.Collections.Generic;
using System.Text;

namespace zavrsna.dal.Domain
{
    public abstract class BaseEntitity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        protected BaseEntitity()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}
