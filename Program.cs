using System;
using System.Collections.Generic;
using dicionarioProjeto1;
//using Pokemon.DicionarioProjeto1;
//using Pokemon.TipoPokemon;
using tipoPokemon;

namespace Pokemon
{
    class Pokemon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Pokémon---------");
            var pokedex = new Estrutura();
            pokedex.CadastroId = 1;
            pokedex.Nome = "Bulbasaur";
            pokedex.TipoPokemon = (Tipo)4;
            pokedex.TipoPokemon = (Tipo)7;

            var pokedex1 = new Estrutura();
            pokedex1.CadastroId = 4;
            pokedex1.Nome = "Charmander";
            pokedex1.TipoPokemon = (Tipo)1;

            var pokedex2 = new Estrutura();
            pokedex2.CadastroId = 7;
            pokedex2.Nome = "Squirtle";
            pokedex2.TipoPokemon = (Tipo)2;

            var pokedex3 = new Estrutura();
            pokedex3.CadastroId = 25;
            pokedex3.Nome = "Pikachu";
            pokedex3.TipoPokemon = (Tipo)3;

            var pokedex4 = new Estrutura();
            pokedex4.CadastroId = 17;
            pokedex4.Nome = "Pidgeotto";
            pokedex4.TipoPokemon = (Tipo)9;

            var pokedex5 = new Estrutura();
            pokedex5.CadastroId = 17;
            pokedex5.Nome = "Butterfree";
            pokedex5.TipoPokemon = (Tipo)11;
            pokedex5.TipoPokemon = (Tipo)9;

            var Pokedex = new List<Estrutura>();

            Pokedex.Add(pokedex);
            Pokedex.Add(pokedex1);
            Pokedex.Add(pokedex2);
            Pokedex.Add(pokedex3);
            Pokedex.Add(pokedex4);
            Pokedex.Add(pokedex5);

            var quantidadePorTipo = new Dictionary<Tipo, int>();
            foreach (var pokeDex in Pokedex)
            {
                if (quantidadePorTipo.ContainsKey(pokeDex.TipoPokemon))
                    quantidadePorTipo[pokeDex.TipoPokemon]++;
                else
                    quantidadePorTipo[pokeDex.TipoPokemon] = 1;
            }

            Console.WriteLine("Quantidade de tipos de pokemons:");
            foreach (var tipos in quantidadePorTipo)
            {
                Console.WriteLine($"{tipos.Key} = {tipos.Value}");
            }
        }
    }
}

