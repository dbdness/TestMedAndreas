using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Console_Unit_Test
{
    class Person
    {
     //Kødhammeren er blå
        // Nej den er grøn
        //keg


        //Vand er godt 
        private int Id;
        private int Alder;
        private string Navn;

        public Person(int id, int alder, string navn)
        {
            SetIdCheck(id);
            Id = id;
            Alder = alder;
            Navn = navn;
        }

        public int Id1
        {
            get { return Id; }
            set
            {
                SetIdCheck(value);
                Id = value;
            }
        }

        public int Alder1
        {
            get { return Alder; }
            set
            {
                SetAlderCheck(value);
                Alder = value;
            }
        }

        public string Navn1
        {
            get { return Navn; }
            set { Navn = value; }
        }

        private static void SetNavnCheck(string value)
        {
            if (value != "Bo")
            {
                
            }
        }
        private static void SetIdCheck(int value)
        {
            if (value < 1000 || value > 9999)
            {
                throw new ArgumentException("HEY, DEN SKAL MELLEM 1000-9999!!!");
            }
            
            
        }

        private static void SetAlderCheck(int value)
        {
            if (value < 18) 
            {
                throw  new ArgumentException("HEY, DU ER IKKE GAMMEL NOK");
            }
            if (value > 30) 
            {
                throw new ArgumentException("HEY, DU ER ALT FOR GAMMEL");
            }
        }
        public override string ToString()
        {
            return string.Format("Id: {0},Alder: {1},Navn,{2}", Id,Alder,Navn);
        }
    }
}
