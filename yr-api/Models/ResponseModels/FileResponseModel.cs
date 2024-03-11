using System;
using yr_api.Models.Entities;
using yr_api.Models.Enums;

namespace yr_api.Models.ResponseModels
{
    public class FileResponseModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public ESeverity Severity { get; set; }
        public bool? isDone { get; set; }
        public bool? isDeleted { get; set; }
        public bool? isImportant { get; set; }
        public DateTime? ReminderOn { get; set; }
        public DateTime? DueOn { get; set; }
        public Cabinet Cabinet { get; set; } = new Cabinet();
        public Style Style { get; set; } = new Style();
    }
}

