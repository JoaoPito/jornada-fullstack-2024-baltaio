using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class UpdateCategoryRequest : Request
{
    public long Id { get; set; }
    
    [Required(ErrorMessage = "Título Inválido")]
    [MaxLength(80, ErrorMessage = "O título deve conter no máximo 80 caracteres")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Descrição inválida")]
    public string? Description { get; set; } = string.Empty;
}