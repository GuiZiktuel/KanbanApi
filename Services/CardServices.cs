using AutoMapper;
using KanbanApi.Data.Dtos.Request;
using KanbanApi.Data.Dtos.Response;
using KanbanApi.Interfaces.Repositories;
using KanbanApi.Interfaces.Services;
using KanbanApi.Models;

namespace KanbanApi.Services;

public class CardServices : ICardService
{
    private IMapper _mapper;
    private ICardRepository _cardRepository;

    public CardServices(IMapper mapper, ICardRepository cardRepository)
    {
        _mapper = mapper;
        _cardRepository = cardRepository;
    }

    public async Task<CardResponse> AddCard(CardRequest cardRequest)
    {
      return _mapper.Map<CardResponse>(await _cardRepository.AddCard(_mapper.Map<Card>(cardRequest)));
    }

    public async Task<CardResponse?> DeleteCard(int id)
    {
        var card = await _cardRepository.GetCardById(id);
        if (card != null)
        {
            return _mapper.Map<CardResponse>(await _cardRepository.DeleteCard(card));
        }
        return null;

    }

    public async Task<CardResponse?> GetCardById(int id)
    {
       return _mapper.Map<CardResponse>(await _cardRepository.GetCardById(id));

    }

    public async Task<List<CardResponse>?> GetCards()
    {
        
        return _mapper.Map<List<CardResponse>?>(await _cardRepository.GetCards());
    }

    public async Task<CardResponse?> UpdateCard(CardRequest cardRequest)
    {
        var card = await _cardRepository.GetCardById(cardRequest.Id);
        if (card != null)
        {
          
           return _mapper.Map<CardResponse>(await _cardRepository.UpdateCard(_mapper.Map<Card>(cardRequest)));
        }
        return null;

    }
}
