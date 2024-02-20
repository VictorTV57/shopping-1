public class TVA 
{
    private double pourcentage;

    public TVA(double pourcentage)
    {
        this.pourcentage = pourcentage;
    }

    
    public double getPourcent()
    {
        return this.pourcentage;
    }

    public double getTTC(double prix)
    {
        double ttc = prix*(1+(0.01*pourcentage));
        return ttc;
    }

}