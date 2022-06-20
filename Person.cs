
class Person {
    private int myVar;
    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }

    public int Naam { get; private set; }
    
    public void Naa() {
        this.Naam = 120;
    }
}