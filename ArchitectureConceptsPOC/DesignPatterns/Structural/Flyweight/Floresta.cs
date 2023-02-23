using System;
using System.Collections.Generic;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Flyweight
{
    public class Floresta
    {
        public IList<Arvore> _arvores = new List<Arvore>();

        public Arvore PlantarArvore(float x, float y, ArvoreTipo tipo)
        {
            var arvore = new Arvore()
            {
                X = x,
                Y = y,
                ArvoreTipo = tipo
            };
            _arvores.Add(arvore);
            return arvore;
        }

        public void Draw(string canvas)
        {
            Console.WriteLine($"Desenhando Arvores em {canvas}: ");
            foreach (var item in _arvores)
            {
                Console.WriteLine($"X: {item.X}");
                Console.WriteLine($"Y: {item.Y}");
                Console.WriteLine($"ArvoreTipo: {item.ArvoreTipo}");
            }
        }
    }
}
