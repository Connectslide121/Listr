using Core;
using DataBaseConnection;
using Services.DTOs;
using Services.Interfaces;
using Services.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ListService : IListService
    {
        private readonly DataContext _dataContext;
        private ListServiceMappers _mappers;

        public ListService(DataContext dataContext)
        {
            _dataContext = dataContext;
            _mappers = new ListServiceMappers();
        }

        public bool AddList(ListDTO listDTOToAdd)
        {
            _dataContext.Lists.Add(_mappers.MapListDTOToList(listDTOToAdd));
            _dataContext.SaveChanges();
            return true;
        }

        public List<ListDTO> GetAllLists()
        {
            List<List> lists = _dataContext.Lists.ToList();

            return _mappers.MapListsToListDTOs(lists);
        }

        public ListDTO GetListById(int listId)
        {
            List? list = _dataContext.Lists
                .Where(l => l.ListId == listId)
                .SingleOrDefault();

            return _mappers.MapListToListDTO(list);
        }

        public bool UpdateList(ListDTO listDTOToUpdate)
        {
            List newList = _mappers.MapListDTOToList(listDTOToUpdate);
            List? existingList = _dataContext.Lists.Find(listDTOToUpdate.ListId);
            bool listExists = false;

            if (existingList != null)
            {
                _dataContext.Entry(existingList).CurrentValues.SetValues(newList);
                _dataContext.SaveChanges();
                listExists = true;
            }

            return listExists;
        }

        public bool DeleteList(int listId)
        {
            List? listToDelete = _dataContext.Lists.Find(listId);
            bool listExists = false;

            if (listToDelete != null)
            {
                _dataContext.Lists.Remove(listToDelete);
                _dataContext.SaveChanges();
                listExists = true;
            }

            return listExists;
        }
    }
}
