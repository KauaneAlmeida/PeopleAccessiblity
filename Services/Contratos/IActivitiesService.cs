using DisabledPeopleRegister.Dtos.Activities;
using DisabledPeopleRegister.Models;

namespace DisabledPeopleRegister.Services.Contracts;

public interface IActivitiesService
{
    void Add(CreateActivityDto createActivityDto);

    AtividadesUsuario GetById(int id);
    
    void UpdateById(int id, UpdateActivityDto updateActivityDto);

    void DeleteById(int id);
}