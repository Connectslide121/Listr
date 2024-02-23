using API.InputModels;
using Services.DTOs;

namespace API.Mappers
{
    public class ListControllerMappers
    {
        public ListDTO MapModelTOListDTOToADD(ListInputModelToAdd model)
        {
            ListDTO listDTO = new ListDTO
            {
                ListName = model.ListName,
                CreatedAt = DateTime.Now,
            };

            return listDTO;
        }

        public ListDTO MapModelTOListDTOToUpdate(ListInputModelToUpdate model)
        {
            ListDTO listDTO = new ListDTO
            {
                ListId = model.ListId,
                ListName = model.ListName,
                CreatedAt = model.CreatedAt,
            };

            return listDTO;
        }
    }
}
