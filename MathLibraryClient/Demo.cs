public class X : P
{
    void PrintX()
    {
        PrintP();
        //P p = new P();
        //p.PrintP();
    }

}

public class Y
{
    void PrintY()
    {
        P p = new P();
        // p.PrintP();
    }
}