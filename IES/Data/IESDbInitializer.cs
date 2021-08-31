using IES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IES.Data
{
    public class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {
            context.Database.EnsureCreated();

            PopulaDepartamento(context);
            PopulaInstituicao(context);
        }

        private static void PopulaDepartamento(IESContext context)
        {
            if (context.Departamentos.Any())
            {
                return;
            }

            var departamentos = new Departamento[]
            {
                new Departamento {Nome="Ciência da Computação"},
                new Departamento {Nome="Ciência de Alimentos"}
            };

            foreach (Departamento d in departamentos)
            {
                context.Departamentos.Add(d);
                context.SaveChanges();
            }
        }
        private static void PopulaInstituicao(IESContext context)
        {
            if (context.Instituicoes.Any())
            {
                return;
            }

            var instituicoes = new Instituicao[]
            {
                 new Instituicao() {
                Nome = "UniParana",
                Endereco = "Paraná"
            },
            new Instituicao() {
                Nome = "UniSanta",
                Endereco = "Santa Catarina"
            },
            new Instituicao() {
                Nome = "UniSãoPaulo",
                Endereco = "São Paulo"
            },
            new Instituicao() {
                Nome = "UniSulgrandense",
                Endereco = "Rio Grande do Sul"
            },
            new Instituicao() {
                Nome = "UniCarioca",
                Endereco = "Rio de Janeiro"
            },
            };

            foreach (Instituicao i in instituicoes)
            {
                context.Instituicoes.Add(i);
                context.SaveChanges();
            }
        }
    }
}
