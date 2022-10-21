# OOP7-Polymorphism

# Om uppgiften

I denna uppgift kommer du �va p� att anv�nda Polymorphism inom objektorientering. Uppgiften handlar till stor del om att t�nka ut en struktur f�r Polymorphism .

# Vad du ska g�ra

- [x]  Du ska skapa en klass som ska vara ParentClass till de andra klasserna som ska �rva fr�n den och klassen heter `Geometri{ }` som ska ha en metod som heter `Area()` och dess `return` typ �r double.
- [x]  Du ska skapa fem klasser till som ska �rva fr�n Geometriklassen och klasserna ska heta `Rektangel`, `Fyrkant`, `Cirkel` , Parallellogram och Ellips. Alla klasser ska ha en metod som heter `Area().`
- [x]  Varje klass ska ha minst en egenskap, till exempel:
    
    ```csharp
    public class Cirkel{
         public double Radius {get; set;}
    }
    ```
    
- [x]  I alla ChildClasses ska vi overrida metoden `Area()` med olika implementeringar. Eftersom arean f�r en cirkel inte r�knas ut p� samma s�tt som arean f�r en fyrkant.
- [x]  Alla ChildClasses m�ste ha en konstruktor f�r att ge v�rde till egenskaperna och vi ska ge den ett fast v�rde i konstruktorn. Till exempel:
    
    ```csharp
    public Cirkel{
          Radius = 4;
    }
    ```
    
- [x]  I void Main()-metoden ska du skapa en object reference fr�n Geometriklassen och den ska peka mot ett objekt av varje klass.