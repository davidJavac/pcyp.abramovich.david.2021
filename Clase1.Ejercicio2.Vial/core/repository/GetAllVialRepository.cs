using Clase1.Ejercicio2.Vial.core.usecase.dto;
using System.Collections.Generic;

namespace Clase1.Ejercicio2.Vial.core.repository
{
    public interface GetAllVialRepository
    {
        public List<VialDto> execute(string path);
    }
}
