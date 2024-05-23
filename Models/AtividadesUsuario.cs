using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisabledPeopleRegister.Models;

[Table("Activities")]
public class AtividadesUsuario
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(18)]
    public string Name { get; set; } = string.Empty;
}