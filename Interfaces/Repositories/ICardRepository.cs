using KanbanApi.Models;

namespace KanbanApi.Interfaces.Repositories;

public interface ICardRepository
{
    Task<List<Card>?> GetCards();
    Task<Card?> GetCardById(int id);
    Task<Card> AddCard(Card card);
    Task<Card> UpdateCard(Card card);
    Task<Card> DeleteCard(Card card);
   
}
