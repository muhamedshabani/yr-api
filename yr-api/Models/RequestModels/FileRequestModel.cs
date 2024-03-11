using System;
using yr_api.Models.Enums;

namespace yr_api.Models.RequestModels
{
    public class FileRequestModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public ESeverity Severity { get; set; }
        public bool? isDone { get; set; }
        public bool? isDeleted { get; set; }
        public bool? isImportant { get; set; }
        public DateTime? ReminderOn { get; set; }
        public DateTime? DueOn { get; set; }
        public Guid CabinetId { get; set; }
    }
}

