using DisabledPeopleRegister.Dtos.Activities;
using DisabledPeopleRegister.Models;
using DisabledPeopleRegister.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace DisabledPeopleRegister.Repositories;

public class ActivitiesRepository(DatabaseContext databaseContext) : IActivitiesRepository
{
    public void Add(CreateActivityDto createActivityDto)
    {
        var activity = new AtividadesUsuario
        {
            Name = createActivityDto.Name
        };

        databaseContext.Activities.Add(activity);
        databaseContext.SaveChanges();
    }

    public AtividadesUsuario GetById(int id)
    {
        return databaseContext.Activities.Find(id);
    }

    public void UpdateById(int id, UpdateActivityDto updateActivityDto)
    {
        var activity = GetById(id);

        activity.Name = updateActivityDto.Name;

        databaseContext.Activities.Update(activity);
        databaseContext.SaveChanges();
    }

    public void DeleteById(int id)
    {
        databaseContext.Activities.Where(activity => activity.Id == id).ExecuteDelete();
    }
}