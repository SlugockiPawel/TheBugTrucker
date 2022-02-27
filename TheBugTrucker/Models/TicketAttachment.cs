﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace TheBugTrucker.Models
{
    public class TicketAttachment
    {
        public int Id { get; set; }

        [DisplayName("Ticket")] public int TicketId { get; set; }

        [DisplayName("File Date")] public DateTimeOffset Created { get; set; }

        [DisplayName("Team Member")] public string UserId { get; set; } = default!;
        [DisplayName("File Description")] public string Description { get; set; } = default!;

        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile FormFile { get; set; } = default!;

        [DisplayName("File Name")] public string FileName { get; set; } = default!;
        public byte[] FileData { get; set; } = default!;

        [DisplayName("FIle Extension")] public string FileContentType { get; set; } = default!;


// Navigation Properties
        public virtual Ticket Ticket { get; set; }
        public virtual BTUser User { get; set; } = default!;
    }
}