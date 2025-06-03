using KanbanApi.Data.Dtos.Request;
using KanbanApi.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace KanbanApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CardController : ControllerBase
{
    private ICardService _cardService;

    public CardController(ICardService cardService)
    {
        _cardService = cardService;
    }

    [HttpPost]

    public async Task<IActionResult> AddCards([FromBody] CardRequest cardDto)
    {
        await _cardService.AddCard(cardDto);
        return Created();

    }

    [HttpGet("{id}")]
    public async Task<IActionResult> RecuperaCardPorId(int id)
    {
        return Ok(await _cardService.GetCardById(id));
    }
    [HttpGet]

    public async Task<IActionResult> GetCards()
    {

        return Ok(await _cardService.GetCards());
    }

    [HttpPut]

    public async Task<IActionResult> UpdateCard([FromBody] CardRequest card)
    {
        await _cardService.UpdateCard(card);
        return Ok();
    }
    [HttpDelete("{id}")]

    public async Task<IActionResult> DeleteCard(int id)
    {
        await _cardService.DeleteCard(id);
        return Ok();
    }

}
