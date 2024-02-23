using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IListItemService
    {
        bool AddListItem(ListItemDTO listItemDTO);
        List<ListItemDTO> GetListItemsByListId(int listId);
        ListItemDTO GetListItemById(int listItemId);
        bool UpdateListItem(ListItemDTO listItemDTO);
        bool DeleteListItem(int listItemId);
    }
}
