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
    public class ListController : ControllerBase
    {
        private readonly IListService _listService;
        private ListControllerMappers _mappers;

        public ListController(IListService listService)
        {
            _listService = listService;
            _mappers = new ListControllerMappers();
        }

        [HttpGet("all")]
        public IActionResult GetAllLists()
        {
            List<ListDTO> listDTOs = _listService.GetAllLists();
            return listDTOs == null ? NotFound() : Ok(listDTOs);
        }

        [HttpGet("List/{id}")]
        public IActionResult GetListById(int id)
        {
            ListDTO listById = _listService.GetListById(id);
            return listById == null ? NotFound() : Ok(listById);
        }

        [HttpPost("create")]
        public IActionResult CreateList(ListInputModelToAdd model)
        {
            ListDTO listDTO = _mappers.MapModelTOListDTOToADD(model);
            _listService.AddList(listDTO);
            return Ok(listDTO);
        }

        [HttpPut("update")]
        public IActionResult UpdateList(ListInputModelToUpdate model)
        {
            ListDTO listDTO = _mappers.MapModelTOListDTOToUpdate(model);
            bool listUpdated = _listService.UpdateList(listDTO);

            return listUpdated == false ? NotFound() : Ok(listDTO);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteList(int id)
        {
            bool listDeleted = _listService.DeleteList(id);

            return listDeleted == false ? NotFound() : Ok(id);
        }


    }
}
