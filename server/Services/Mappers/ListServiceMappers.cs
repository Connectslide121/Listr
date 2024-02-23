using Core;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mappers
{
    internal class ListServiceMappers
    {
        public List MapListDTOToList(ListDTO listDTO)
        {
            List list = new List
            {
                ListId = listDTO.ListId,
                ListName = listDTO.ListName,
                ListItems = MapListItemDTOsToListItems(listDTO.ListItemDTOs),
                CreatedAT = listDTO.CreatedAt
            };

            return list;
        }

        public ListDTO MapListToListDTO(List list)
        {
            ListDTO listDTO = new ListDTO
            {
                ListId = list.ListId,
                ListName = list.ListName,
                ListItemDTOs = MapListItemsToListItemDTOs(list.ListItems),
                CreatedAt = list.CreatedAT
            };

            return listDTO;
        }

        public List<ListDTO> MapListsToListDTOs(List<List> lists)
        {
            List<ListDTO> listDTOs = new List<ListDTO>();

            foreach (List list in lists)
            {
                ListDTO listDTO = new ListDTO
                {
                    ListId = list.ListId,
                    ListName = list.ListName,
                    ListItemDTOs = MapListItemsToListItemDTOs(list.ListItems),
                    CreatedAt = list.CreatedAT
                };

                listDTOs.Add(listDTO);
            }

            return listDTOs;
        }

        public List<ListItem> MapListItemDTOsToListItems(List<ListItemDTO> listItemDTOs)
        {
            List<ListItem> listItems = new List<ListItem>();

            if(listItemDTOs != null)
            {
                foreach (ListItemDTO listItemDTO in listItemDTOs)
                {
                    ListItem listItem = new ListItem
                    {
                        ListItemId = listItemDTO.ListItemId,
                        ListId = listItemDTO.ListItemId,
                        Title = listItemDTO.Title,
                        Information = listItemDTO.Information,
                        Status = listItemDTO.Status,
                        CreatedAT = listItemDTO.CreatedAt,
                        UpdatedAt = listItemDTO.UpdatedAt
                    };

                    listItems.Add(listItem);
                }
            }

            return listItems;
        }

        public List<ListItemDTO> MapListItemsToListItemDTOs(List<ListItem> listItems)
        {
            List<ListItemDTO> listItemDTOs = new List<ListItemDTO>();

            if(listItems != null)
            {
                foreach (ListItem listItem in listItems)
                {
                    ListItemDTO listItemDTO = new ListItemDTO
                    {
                        ListItemId = listItem.ListItemId,
                        ListId = listItem.ListItemId,
                        Title = listItem.Title,
                        Information = listItem.Information,
                        Status = listItem.Status,
                        CreatedAt = listItem.CreatedAT,
                        UpdatedAt = listItem.UpdatedAt
                    };

                    listItemDTOs.Add(listItemDTO);
                }
            }

            return listItemDTOs;
        }
    }
}
