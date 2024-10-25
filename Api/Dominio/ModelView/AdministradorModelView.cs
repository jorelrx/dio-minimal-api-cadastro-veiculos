using MinimalApi.Dominio.DTOs.Enums;

namespace MinimalApi.Dominio.ModelView;

public record AdministradorModelView
{
        public int Id { get; set; }
        public string Email { get; set; }
        public string Perfil { get; set; }
}