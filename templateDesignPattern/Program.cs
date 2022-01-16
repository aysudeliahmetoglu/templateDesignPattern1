using System;

namespace templateDesignPattern
{
    enum OdemeTipi // Değişkenlerin alabileceği değerlerin sabit  olduğu durumlarda programı daha okunabilir hale getirmek için kullanılır. 
    { 
    Pesin,Taksit
    }
    abstract class Alisveris
    {
        protected string ProductName;
        protected OdemeTipi odemeTipi;
        void Baslat()
        {
            Console.WriteLine("alışveriş başladı");
        }
        void Bitir()
        {
            Console.WriteLine($"alışveriş bitti.{ProductName} {odemeTipi} yöntemiyle alınmıştır.");
        
        }

        abstract public void Urun();
        abstract public void OdemeSekli();
        public void TemplateMethod()
        {
            Baslat();
            Urun();
            OdemeSekli();
            Bitir();
        }

    
    
    }

    class Televizyon :Alisveris // concrete class
    {
        public override void OdemeSekli()
        {
            odemeTipi = OdemeTipi.Pesin;
        }
        public override void Urun()
        {
            ProductName = "televizyon";
                
        }
    }
    class Buzdolabi : Alisveris //concrete class
    {
        public override void OdemeSekli()
        {
            odemeTipi = OdemeTipi.Taksit;
        }
        public override void Urun()
        {
            ProductName = "buzdolabı";

        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Alisveris alisveris1 = new Televizyon();
            alisveris1.TemplateMethod();
            Console.WriteLine("***********");
            Alisveris alisveris2 = new Buzdolabi();
            alisveris2.TemplateMethod();

            Console.Read();
        }
    }
}
