﻿using System.ComponentModel;

namespace TheBugTrucker.Models
{
    public class TicketHistory
    {
        public int Id { get; set; }

        [DisplayName("Ticket")] public int TicketId { get; set; } = default!;

        [DisplayName("Updated Item")] public int Property { get; set; } = default!;

        [DisplayName("Previous")] public int OldValue { get; set; } = default!;

        [DisplayName("Current")] public int NewValue { get; set; } = default!;

        [DisplayName("Date Modified")] public DateTimeOffset Created { get; set; }
        [DisplayName("Description of Change")] public string Description { get; set; } = default!;

        [DisplayName("Team Member")] public string UserId { get; set; } = default!;


        // Navigation Properties
        public virtual Ticket Ticket { get; set; }
        public virtual BTUser User { get; set; } = default!;
    }
}