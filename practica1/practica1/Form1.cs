﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Persona persona = new Persona();

            persona.nombre = "Alejandro";

            Console.WriteLine("persona.nombre " + persona.nombre);

            persona.Cantar();

            persona.Respirar();

            Celular celular = new Celular();

            celular.color = "negro";

            Console.WriteLine("celular.color" + celular.color);

            celular.Comunicar();

            TV TV = new TV();

            TV.tamaño = "grande";

            Console.WriteLine("TV.tamaño" + TV.tamaño);

            TV.VerVideos();

            Carro carro = new Carro();

            carro.color = "rojo";

            Console.WriteLine("carro.peso" + carro.color);

            carro.Viajar();

            Laptop laptop = new Laptop();

            laptop.color = "morado"; 

            Console.WriteLine("laptop.color" + laptop.color);
            
            laptop.NavegarEnInternet();

            León león = new León();

            león.peso = 290;

            Console.WriteLine("león.peso" + león.peso);

            león.Dormir();
        }
    }
}
