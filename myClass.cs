namespace GitExercise
{
    class myClass
    {
        
            private string _navn;
            private string _adress;
            private int _postnr;

            
            public string navn { get; set; }
            public string adress { get; set; }
            public int postnr { get; set; }

            

        public myClass(string navn, string adress, int postnr)
        {
            _navn = navn;
            _adress = adress;
            _postnr = postnr;
            
        }
        public override string ToString(){
            return $"{navn}'s adresse er {adress} i {postnr}";
        }
    }
}