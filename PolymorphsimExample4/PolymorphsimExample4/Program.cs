using System;

namespace PolymorphsimExample4
{
    class Kit
    {
        public virtual void CricketEquip()
        {
            Console.WriteLine("Equipment used for playing cricket");
        }
    }
    class Cricket:Kit
    {
        public override void CricketEquip()
        {
            Console.WriteLine("Playes uses this equipment");
        }
    }
    class TableTanis:Kit
    {
        public override void CricketEquip()
        {
            Console.WriteLine("Playes uses only table tanis bat and ball");
        }
    }
    class Players
    {
        static void Main(string[] args)
        {
            Kit k1 = new Kit();
            Kit c1 = new Cricket();
            Kit t1 = new TableTanis();
            k1.CricketEquip();
            c1.CricketEquip();
            t1.CricketEquip();
        }
    }
}
//polymorphsim:one interface multiple functions