using System.ComponentModel.DataAnnotations.Schema;
using yr_api.Models.Enums;

namespace yr_api.Models.Entities;

public class File : Base
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public ESeverity Severity { get; set; }
    public bool? isDone { get; set; }
    public bool? isDeleted { get; set; }
    public bool? isStarred { get; set; }
    public DateTime? ReminderOn { get; set; }
    public DateTime? DueOn { get; set; }

    [ForeignKey(nameof(Label))]
    public Guid LabelId { get; set; }
    public Label Label { get; set; }

    [ForeignKey(nameof(Cabinet))]
    public Guid CabinetId { get; set; }
    public virtual Cabinet Cabinet { get; set; }
}