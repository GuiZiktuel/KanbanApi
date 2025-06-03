using KanbanApi.Models;
using Microsoft.EntityFrameworkCore;

namespace KanbanApi.Data;

public class CardContext : DbContext
{
    public CardContext(DbContextOptions<CardContext> opts) : base(opts)
    {

    }
    public DbSet<Card> Cards { get; set; }
}
