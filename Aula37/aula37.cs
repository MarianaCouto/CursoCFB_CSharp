﻿using System;

class Base{
    public Base(){
        Console.WriteLine("Construtor da classe Base");
    }
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da Derivada 1");
            }            
}

class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da Derivada 2");
            }            
}

class Aula37{ //Herança/Ordem de execução dos construtores: executa primeiro a base e depois as derivadas.
    static void Main(){
        Derivada2 d2 = new Derivada2();      


    }
    
}


