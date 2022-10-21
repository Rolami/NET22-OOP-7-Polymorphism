# OOP7-Polymorphism

# Om uppgiften

I denna uppgift kommer du öva på att använda Polymorphism inom objektorientering. Uppgiften handlar till stor del om att tänka ut en struktur för Polymorphism .

# Vad du ska göra

- [x]  Du ska skapa en klass som ska vara ParentClass till de andra klasserna som ska ärva från den och klassen heter `Geometri{ }` som ska ha en metod som heter `Area()` och dess `return` typ är double.
- [x]  Du ska skapa fem klasser till som ska ärva från Geometriklassen och klasserna ska heta `Rektangel`, `Fyrkant`, `Cirkel` , Parallellogram och Ellips. Alla klasser ska ha en metod som heter `Area().`
- [x]  Varje klass ska ha minst en egenskap, till exempel:
    
    ```csharp
    public class Cirkel{
         public double Radius {get; set;}
    }
    ```
    
- [x]  I alla ChildClasses ska vi overrida metoden `Area()` med olika implementeringar. Eftersom arean för en cirkel inte räknas ut på samma sätt som arean för en fyrkant.
- [x]  Alla ChildClasses måste ha en konstruktor för att ge värde till egenskaperna och vi ska ge den ett fast värde i konstruktorn. Till exempel:
    
    ```csharp
    public Cirkel{
          Radius = 4;
    }
    ```
    
- [x]  I void Main()-metoden ska du skapa en object reference från Geometriklassen och den ska peka mot ett objekt av varje klass.