namespace Polioformismo
{
    public class player
    {
        public int vida { get; set; }
        public virtual void pulo (){
            System.Console.WriteLine("o personagem pulou");
        }
        public virtual void Correr(){
            System.Console.WriteLine("o personagem correu");
        }
    }
}