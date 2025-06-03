using KanbanApi.Data.Dtos.Request;
using KanbanApi.Data.Dtos.Response;

namespace KanbanApi.Interfaces.Services;

public interface ICardService
{
    Task<List<CardResponse>?> GetCards();
    Task<CardResponse?> GetCardById(int id);
    Task<CardResponse> AddCard(CardRequest card);
    Task<CardResponse> UpdateCard(CardRequest card);
    Task<CardResponse> DeleteCard(int id);
}