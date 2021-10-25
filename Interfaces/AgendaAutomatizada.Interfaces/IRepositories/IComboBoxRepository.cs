using AgendaAutomatizada.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Interfaces.IRepositories
{
    public interface IComboBoxRepository
    {
        List<ComboBoxDTO> TandaComboBox();
        List<ComboBoxDTO> DiasComboBox();
    }
}
