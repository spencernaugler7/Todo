using System.ComponentModel.DataAnnotations;

namespace BlazorTodo.Models;

public class TodoItem: IEquatable<TodoItem>, IComparable<TodoItem>
{
    public Guid Id { get; } = Guid.NewGuid();
    [Required]
    public string? Description { get; set; }
    [Required]
    public DateTime? DueDate { get; set; }
    [Required]
    public bool IsDone { get; set; }
    
    public bool Equals(TodoItem? other)
    {
        return DueDate.Value == other.DueDate.Value;
    }

    public int CompareTo(TodoItem? other)
    {
        return DateTime.Compare(DueDate.Value, other.DueDate.Value);
    }
}