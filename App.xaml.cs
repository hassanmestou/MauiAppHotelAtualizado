﻿using MauiAppHotel1.Models;

namespace MauiAppHotel1
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suite Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },

            new Quarto()
            {
                Descricao = "Suite Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },

            new Quarto()
            {
                Descricao = "Suite Single",
                ValorDiariaAdulto = 50,
                ValorDiariaCrianca = 25
            },
            new Quarto()
            {
                Descricao = "Suite Crise",
                ValorDiariaAdulto = 35,
                ValorDiariaCrianca = 12.5
            },
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}