using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        
       //Chuta
        public string Chuta()
        {
           return "Maradona estas pateando.";
        }
        //Corre
        public string Corre()
        {
           return  "Maradona estas corriendo.";
        }
        //Passe
        public string Passe()
        {
            return  "Maradona estas pasando.";
        }
    }
}