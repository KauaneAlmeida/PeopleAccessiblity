using DisabledPeopleRegister.Dtos.Activities;
using DisabledPeopleRegister.Models;
using DisabledPeopleRegister.Repositories.Contracts;
using DisabledPeopleRegister.Services.Contracts;

namespace DisabledPeopleRegister.Services;

public class ActivitiesService(IActivitiesRepository activitiesRepository) : IActivitiesService
{
    public void Add(CreateActivityDto createActivityDto)
    {
        activitiesRepository.Add(createActivityDto);
    }

    public AtividadesUsuario GetById(int id)
    {
        return activitiesRepository.GetById(id);
    }

    public void UpdateById(int id, UpdateActivityDto updateActivityDto)
    {
        activitiesRepository.UpdateById(id, updateActivityDto);
    }

    public void DeleteById(int id)
    {
        activitiesRepository.DeleteById(id);
    }
}