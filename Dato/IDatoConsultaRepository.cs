using Entidad;

namespace Dato
{
    public interface IDatoConsultaRepository : IWriteReapository<Consulta>, IReadRepository<ConsultaDTO>, IDataEditRepository<ConsultaEdicionDTO>
    {
        string ObtenerEmailPropietaio(string codigo);
    }
}
