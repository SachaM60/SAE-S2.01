﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE_S2._01
{
    /// <summary>
    /// Classe représentant un arrêt adjacent à un autre arrêt, avec une distance et une liste de lignes associées.
    /// </summary>
    public class ArretAdjacent
    {
        private Arret arret;
        private double temps;
        private List<int> ligne;

        public ArretAdjacent(Arret arret, double temps, List<int> ligne)
        {
            // Constructeur de la classe ArretAdjacent, initialise les propriétés de l'arrêt adjacent
            this.arret = arret;
            this.temps = temps;
            this.ligne = ligne;
        }

        public double Distance { get => temps; set => temps = value; }
        public List<int> Ligne { get => ligne; set => ligne = value; }
        public Arret Arret { get => arret; set => arret = value; }

        public override string ToString()
        {
            // Retourne une représentation en chaîne de caractères de l'arrêt adjacent, incluant son nom, sa distance et les lignes associées
            return $"ArretAdjacent: {arret.Nom}, Temps : {temps}, Lignes: [{string.Join(", ", ligne)}]";
        }
    }
}
