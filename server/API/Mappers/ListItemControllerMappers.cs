using API.InputModels;
using Services.DTOs;

namespace API.Mappers
{
    public class ListItemControllerMappers
    {
        public ListItemDTO MapModelToListItemDTOToADD(ListItemInputModelToAdd model)
        {
            ListItemDTO listItemDTO = new ListItemDTO
            {
                ListId = model.ListId,
                Title = model.Title,
                Information = model.Information,
                Status = model.Status,
                CreatedAt = DateTime.Now,
            };

            return listItemDTO;
        }

        public ListItemDTO MapModelToListItemDTOToUpdate(ListItemInputModelToUpdate model)
        {
            ListItemDTO listItemDTO = new ListItemDTO
            {
                ListItemId = model.ListItemId,
                ListId = model.ListId,
                Title = model.Title,
                Information = model.Information,
                Status = model.Status,
                CreatedAt = model.CreatedAt,
            };

            return listItemDTO;
        }
    }
}
