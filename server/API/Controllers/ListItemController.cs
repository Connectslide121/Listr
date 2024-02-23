using API.InputModels;
using API.Mappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using Services.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListItemController : ControllerBase
    {
        private readonly IListItemService _listItemService;
        private ListItemControllerMappers _mappers;

        public ListItemController(IListItemService listItemService)
        {
            _listItemService = listItemService;
            _mappers = new ListItemControllerMappers();
        }

        [HttpGet("List/{id}")]
        public IActionResult GetListItemsByListId(int id)
        {
            List<ListItemDTO> listDTOs = _listItemService.GetListItemsByListId(id);

            return listDTOs == null ? NotFound() : Ok(listDTOs);
        }

        [HttpGet("listItem/{id}")]
        public IActionResult GetListItemById(int id)
        {
            ListItemDTO listItemDTO = _listItemService.GetListItemById(id);
            return listItemDTO == null ? NotFound() : Ok(listItemDTO);
        }

        [HttpPost("create")]
        public IActionResult CreateListItem(ListItemInputModelToAdd model)
        {
            Console.WriteLine("create http request received");

            ListItemDTO listItemDTO = _mappers.MapModelToListItemDTOToADD(model);
            _listItemService.AddListItem(listItemDTO);
            return Ok(listItemDTO);
        }

        [HttpPut("update")]
        public IActionResult UpdateListItem(ListItemInputModelToUpdate model)
        {
            Console.WriteLine("update http request received");

            ListItemDTO listItemDTO = _mappers.MapModelToListItemDTOToUpdate(model);
            bool listItemUpdated = _listItemService.UpdateListItem(listItemDTO);

            return listItemUpdated == false ? NotFound() : Ok(listItemUpdated);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteListItem(int id)
        {
            bool listItemDeleted = _listItemService.DeleteListItem(id);

            return listItemDeleted == false ? NotFound() : Ok(listItemDeleted);
        }


    }
}
