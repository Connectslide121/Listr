using Core;
using DataBaseConnection;
using Services.DTOs;
using Services.Interfaces;
using Services.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ListItemService : IListItemService
    {
        private readonly DataContext _dataContext;
        private ListItemServiceMappers _mappers;

        public ListItemService(DataContext dataContext)
        {
            _dataContext = dataContext;
            _mappers = new ListItemServiceMappers();
        }

        public bool AddListItem(ListItemDTO listItemDTOToAdd)
        {
            _dataContext.ListItems.Add(_mappers.MapListItemDTOToListItem(listItemDTOToAdd));
            _dataContext.SaveChanges();
            return true;
        }

        public List<ListItemDTO> GetListItemsByListId(int listId)
        {
            List<ListItem>? listItems = _dataContext.ListItems
                .Where(l => l.ListId == listId).ToList();

            return _mappers.MapListItemsToListItemDTOs(listItems);
        }

        public ListItemDTO GetListItemById(int listItemId)
        {
            ListItem? listItem = _dataContext.ListItems
                .Where(l => l.ListItemId == listItemId)
                .SingleOrDefault();

            return _mappers.MapListItemToListItemDTO(listItem);
        }

        public bool UpdateListItem(ListItemDTO listItemDTOToUpdate)
        {
            ListItem newListItem = _mappers.MapListItemDTOToListItem(listItemDTOToUpdate);
            ListItem? existingListItem = _dataContext.ListItems.Find(listItemDTOToUpdate.ListItemId);
            bool listItemExists = false;

            if (existingListItem != null)
            {
                _dataContext.Entry(existingListItem).CurrentValues.SetValues(newListItem);
                _dataContext.SaveChanges();
                listItemExists = true;
            }

            return listItemExists;
        }

        public bool DeleteListItem(int listItemId)
        {
            ListItem? listItemToDelete = _dataContext.ListItems.Find(listItemId);
            bool listItemExists = false;

            if (listItemToDelete != null)
            {
                _dataContext.ListItems.Remove(listItemToDelete);
                _dataContext.SaveChanges();
                listItemExists = true;
            }

            return listItemExists;
        }

    }
}
