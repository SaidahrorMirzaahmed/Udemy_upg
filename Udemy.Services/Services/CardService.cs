using Udemy.DataAccess.Repositories;
using Udemy.Domain.Entites;
using Udemy.Services.DTOs.Cards;
using Udemy.Services.DTOs.Cources;
using Udemy.Services.Helpers;
using Udemy.Services.Interfaces;

namespace Udemy.Services.Services;

public class CardService : ICardService
{
    private readonly Genericss<Card> context;
    public async ValueTask<CardView> CreateAsync(CardCreate cardCreation)
    {
        await context.InsertAsync(cardCreation.MapTo<Card>());
        await context.SaveAsync();
        return cardCreation.MapTo<CardView>();
    }

    public async ValueTask<bool> DeleteAsync(int id)
    {
        var card = await context.SelectAsync(id);
        await context.DeleteAsync(card);
        await context.SaveAsync();
        return true;
    }

    public async ValueTask<List<CardView>> GetAllAsync()
    {
        var cards = context.SelectAllAsEnumerable();
        return cards.ToList().Select(x => x.MapTo<CardView>()).ToList();
    }

    public async ValueTask<CardView> GetByIdAsync(int id)
    {
        var card = await context.SelectAsync(id);
        return card.MapTo<CardView>();
    }

    public async ValueTask<CardView> UpdateAsync(int id, CardCreate cardViewModel)
    {
        var card = await context.SelectAsync(id);

        card.UpdatedAt = DateTime.UtcNow;
        card.Balance = cardViewModel.Balance;

        await context.UpdateAsync(card);
        await context.SaveAsync();
        return card.MapTo<CardView>();
    }
}
