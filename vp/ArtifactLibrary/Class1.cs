using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactLibrary
{
    public class Artifact
    {
        string name;
        int attack;
        int hp = 100;
        int price;
        int percents;
        int deffence;


        public string Name
        { get { return name; } set { Name = value; } }

        public int Attack
        { get { return attack;} set { attack = value; } }

        public int Hp 
        { get { return hp;} set { hp = value; } }

        public int Price
        { get { return price;} set { price = value; } }

        public int Percents
        { get { return percents;} set { percents = value; } }

        public int Deffence
        { get { return deffence;} set { deffence = value; } }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Возвращает цену с учетом скидки</returns>
        public float GetPrice()
        {
            return price - percents;
        }

       

    }

    public class Person
    {
        /// HP, атака, защита, сумма денег.
        /// 
        int hp;
        int attack;
        int defence;
        int bank;

        public int Hp
        { get { return hp;} set { hp = value; } }

        public int Attack
        { get { return attack;} set { attack = value; } }

        public int Defence
        { get { return defence;} set { defence = value; } }

        public int Bank
        { get { return bank;} set { bank = value; } }
    }
}
