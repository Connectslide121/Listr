using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IListService
    {
        bool AddList(ListDTO listDTO);
        List<ListDTO> GetAllLists();
        ListDTO GetListById(int listId);
        bool UpdateList(ListDTO listDTO);
        bool DeleteList(int listId);
    }
}
