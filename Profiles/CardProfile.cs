using AutoMapper;
using KanbanApi.Data.Dtos.Request;
using KanbanApi.Data.Dtos.Response;
using KanbanApi.Models;

namespace KanbanApi.Profiles

{
    public class CardProfile : Profile
    {
        public CardProfile()
        {
            CreateMap<CardRequest, Card>();
            CreateMap<Card, CardResponse>();

        }


    }
}
