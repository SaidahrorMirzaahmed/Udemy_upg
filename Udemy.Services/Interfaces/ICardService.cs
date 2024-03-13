using Udemy.Services.DTOs.Cards;
using Udemy.Services.DTOs.Cources;

namespace Udemy.Services.Interfaces;

public interface ICardService
{
    public ValueTask<CardView> CreateAsync(CardCreate cardCreation);
    public ValueTask<CardView> UpdateAsync(int id, CardCreate cardViewModel);
    public ValueTask<bool> DeleteAsync(int id);
    public ValueTask<CardView> GetByIdAsync(int id);
    public ValueTask<List<CardView>> GetAllAsync();
}