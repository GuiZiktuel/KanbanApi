using KanbanApi.Data;
using KanbanApi.Interfaces.Repositories;
using KanbanApi.Models;
using Microsoft.EntityFrameworkCore;

namespace KanbanApi.Repositories;

public class CardRepository : ICardRepository
{
    private CardContext _db;
	public CardRepository(CardContext db)
	{
		_db = db;
	}

	public async Task<List<Card>?> GetCards()
	{
		return await _db.Cards.ToListAsync();
	}

	public async Task<Card?> GetCardById(int id)
	{
		return await _db.Cards.FirstOrDefaultAsync(x => x.Id == id);
	}
	public async Task<Card?> AddCard(Card card)
	{
		await _db.Cards.AddAsync(card);
		await _db.SaveChangesAsync();
		return card;
	}
	public async Task<Card> UpdateCard(Card card)
	{
		_db.Cards.Update(card);
		await _db.SaveChangesAsync();
		return card;
	}
	public async Task<Card> DeleteCard(Card card)
	{
		_db.Cards.Remove(card);
		await _db.SaveChangesAsync();
		return card;
	}
}