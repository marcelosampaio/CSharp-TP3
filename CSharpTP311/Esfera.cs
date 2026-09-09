public class Esfera
{
    public double Raio;
    
    public double CalcularVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(Raio, 3);
    }
}