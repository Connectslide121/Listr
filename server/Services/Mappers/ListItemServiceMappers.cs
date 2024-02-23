using Core;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mappers
{
    internal class ListItemServiceMappers
    {
        public ListItem MapListItemDTOToListItem(ListItemDTO listItemDTO)
        {
            ListItem listItem = new ListItem
            {
                ListItemId = listItemDTO.ListItemId,
                ListId = listItemDTO.ListId,
                Title = listItemDTO.Title,
                Information = listItemDTO.Information,
                Status = listItemDTO.Status,
                CreatedAT = listItemDTO.CreatedAt,
                UpdatedAt = listItemDTO.UpdatedAt
            };

            return listItem;
        }

        public List<ListItemDTO> MapListItemsToListItemDTOs(List<ListItem> listItems)
        {
            List<ListItemDTO> listItemDTOs = new List<ListItemDTO>();

            foreach (ListItem listItem in listItems)
            {
                ListItemDTO listItemDTO = new ListItemDTO
                {
                    ListItemId = listItem.ListItemId,
                    ListId = listItem.ListId,
                    Title = listItem.Title,
                    Information = listItem.Information,
                    Status = listItem.Status,
                    CreatedAt = listItem.CreatedAT,
                    UpdatedAt = listItem.UpdatedAt
                };

                listItemDTOs.Add(listItemDTO);
            }

            return listItemDTOs;
        }

        public ListItemDTO MapListItemToListItemDTO(ListItem listItem)
        {
            ListItemDTO listItemDTO = new ListItemDTO
            {
                ListItemId = listItem.ListItemId,
                ListId = listItem.ListId,
                Title = listItem.Title,
                Information = listItem.Information,
                Status = listItem.Status,
                CreatedAt = listItem.CreatedAT,
                UpdatedAt = listItem.UpdatedAt
            };

            return listItemDTO;
        }
    }
}
