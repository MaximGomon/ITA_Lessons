using System.Collections.Generic;
using System.Data.Entity;
using EfSample;

namespace EfExample
{

    public class SampleDbInitializer : CreateDatabaseIfNotExists<SampleDbContext> //this base class used only when db created
    {
        protected override void Seed(SampleDbContext context)
        {
            //Create default data for positions and departments
            List<Position> defaultPositions = new List<Position>();

            defaultPositions.Add(new Position() { Name = "Simple", Code = 1 });
            defaultPositions.Add(new Position() { Name = "Manager", Code = 2 });
            defaultPositions.Add(new Position() { Name = "Director", Code = 3 });

            foreach (var item in defaultPositions)
            {
                context.Positions.Add(item);
            }

            List<Department> defaultDepartments = new List<Department>();

            defaultDepartments.Add(new Department() { Name = "IT", Code = 1 });
            defaultDepartments.Add(new Department() { Name = "QA", Code = 2 });
            defaultDepartments.Add(new Department() { Name = "Sales", Code = 3 });

            foreach (var item in defaultDepartments)
            {
                context.Departments.Add(item);
            }

            base.Seed(context);
        }
    }
}