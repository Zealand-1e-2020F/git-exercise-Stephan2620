namespace GitExercise
{
    class myClass
    {
        
            private string _navn; 
            private string _adress;
            private int _postnr;
            private string _by;

            
            public string navn { get; set; }
            public string adress { get; set; }
            public int postnr { get; set; }
            public string by { get; set; }
            

        public myClass(string navn, string adress, int postnr, string by){
            _navn = navn;
            _adress = adress;
            _postnr = postnr;
            _by = by;
        }
        public override string ToString(){
            return $"{navn}'s adresse er {adress} i {by} {postnr}";
        }
        // ¨HEJ MED DIG
    }
}