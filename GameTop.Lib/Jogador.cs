using System;
using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 :IJogador
    {
        public readonly string Nome;

        public Jogador1(string nome="Ronaldo"){
            Nome = nome;
        }
        //Chuta
        public string Chuta()
        {
           return $"{Nome} está Chutando.";
        }
        //Corre
        public string Corre()
        {
           return  $"{Nome} está Correndo.";
        }
        //Passe
        public string Passe()
        {
            return  $"{Nome} está passando.";
        }
    }
}