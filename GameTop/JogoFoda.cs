using System;
using GameTop.Interface;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;

        public JogoFoda(IJogador jogadorA,IJogador jogadorB)
        {
            this._jogadorA = jogadorA;
            this._jogadorB=jogadorB;
        }
         public void IniciarJogo()
        {
           Console.WriteLine(_jogadorA.Corre());
           Console.WriteLine(_jogadorA.Chuta());
           Console.WriteLine(_jogadorA.Passe());

            Console.WriteLine("PRÓXIMO JOGADOR");

          Console.WriteLine(_jogadorB.Corre());
          Console.WriteLine(_jogadorB.Chuta());
          Console.WriteLine(_jogadorB.Passe());
        }
    }
}