using DisabledPeopleRegister.Dtos.Activities;
using DisabledPeopleRegister.Models;

namespace DisabledPeopleRegister.Repositories.Contracts;

public interface IActivitiesRepository
{
    void Add(CreateActivityDto createActivityDto);

    AtividadesUsuario GetById(int id);

    void UpdateById(int id, UpdateActivityDto updateActivityDto);

    void DeleteById(int id);
}