namespace Tbs16.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AutoService.DAL.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AutoService.DAL.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "AutoService.DAL.DBContext";
        }

        protected override void Seed(AutoService.DAL.DBContext context)
        {
            // ���������� �������
            context.Modules.AddOrUpdate(
                p => p.Code,
              new Module {
                  Code = 1,
                  Name = "AddingContentFeatures",
                  Description = "��������� ���� ���������� ��������"
              },
              new Module
              {
                  Code = 2,
                  Name = "AddingSearchToNavigationBar",
                  Description = "��������� ����� �� �����"
              }
            );
                   
            context.Roles.AddOrUpdate(
                p => p.Code,
                new Role
                {
                    Code = 1,
                    Name = "admin",
                    Description = "������������� �������"
                }
            );
        }
    }
}
