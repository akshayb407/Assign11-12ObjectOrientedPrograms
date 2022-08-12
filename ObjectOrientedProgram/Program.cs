using System;

namespace ObjectOrientedProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  CardsSimulation simulation = new CardsSimulation();
          //  simulation.DriverMethod();
            
            DeckOfCards deckOfCards = new DeckOfCards();
            deckOfCards.Shuffle();

        }
    }
}
