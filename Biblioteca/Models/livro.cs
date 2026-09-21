using System.Dynamic;

namespace Biblioteca.Models
{  
    public class Livro
    {
        /* criar os objetos: 
        ID como inteiro(67);
        Título como string ("abcdefg");
        Autor como string ("hijklmn);
        Status como bool/booleano (0/1, verdadeiro/falso)
        
        get busca os dados dentro do objeto, set define os dados.
        ambos são posicionados dentro de brackets de cada objeto para assignar uma função dentro do objeto.
        (ex: Id.get, Autor.set)*/
        public int Id {get; set;} 
        public string Titulo{get; set;}
        public string Autor{get; set;}
        public bool Status{get; set;}
    }
}