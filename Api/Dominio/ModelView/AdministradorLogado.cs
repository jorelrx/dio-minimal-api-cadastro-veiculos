using MinimalApi.Dominio.DTOs.Enums;

namespace MinimalApi.Dominio.ModelView;

public record AdministradorLogado
{
        public string Email { get; set; }
        public string Perfil { get; set; }
        public string Token { get; set; }
}