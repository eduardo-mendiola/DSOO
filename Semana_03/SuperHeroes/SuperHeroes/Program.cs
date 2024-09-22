// See https://aka.ms/new-console-template for more information
using SuperHeroes;

SuperHeroe superHeroe1 = new SuperHeroe("Batman", 90, 70, 0);
SuperHeroe superHeroe2 = new SuperHeroe("Superman", 95, 60, 70);

superHeroe1.competir(superHeroe2);
superHeroe2.competir(superHeroe1);