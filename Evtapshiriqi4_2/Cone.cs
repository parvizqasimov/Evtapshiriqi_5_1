namespace EvTapshiriqi_4_2
{
    public class Cone : spacefigures
    {
        public Cone(double h_c, double r_c,double l_c) : base(h_c, r_c)
        {
            this.l = l_c;
        }           

        public override double SeatArea()
        {
            return (pi * r) / 2;
        }
        public override double Volume()
        {
            return (((pi * r) / 2) * h) / 3;
        }
        public override double ComplateArea()
        {
            return (pi * r *r) + (pi* r +l);
        }
    }
}
