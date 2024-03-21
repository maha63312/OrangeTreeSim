using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {

        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public int Age 
        {
            get { return age; }
            set 
            { 
                if(value >= 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be set to a negative value.");
                }
            }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public bool TreeAlive
        {
            get{ return treeAlive;}
            set{ treeAlive = value;}
        }
        public int NumOranges
        {
            get { return numOranges; }
        }
        public int OrangesEaten
        {
            get{return orangesEaten;}
        }
       

        public void OneYearPasses()
        {
            this.orangesEaten = 0;
            this.age++;
            if (this.age < 80)
            {
                this.height += 2;
                this.treeAlive = true;
                this.numOranges = (this.age - 1) * 5;
            }
            else
            {
                this.treeAlive = false;
                this.numOranges = 0; 
            }
            

        }

        public void EatOrange(int count)
        {
            
            if (this.treeAlive == true && this.numOranges >= count)
            {
                this.numOranges -= count;
                this.orangesEaten += count;
            }
             else
            {
                Console.WriteLine("Error: Cannot eat oranges. </3");
            }

        }
    }

    
}





//public void SetAge(int age)
//{
//    this.age = age;

//}
//public int GetAge() 
//{ 
//    return this.age; 
//}

//public void SetHeight(int height)
//{
//    this.height = height;
//}

//public int GetHeight()
//{
//    return this.height;           
//}

//public void SetTreeAlive(bool treeAlive)
//{
//    this.treeALive = treeAlive;
//}
//public bool GetTreeAlive()
//{
//    return this.treeALive;
//}

//public int GetNumOranges()
//{

//    return this.numOranges;
//}
//public int GetOrangesEaten()
//{
//    return this.orangesEaten;
//}