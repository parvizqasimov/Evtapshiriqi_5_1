namespace EvTapshiriqi_4_2
{
     class Cylinder : spacefigures
    {
        public Cylinder(double height, double radius) : base(height, radius)
        {

        }
        public override double SeatArea()
        {
            return pi * r / 2;
        }
        public override double Volume()
        {
            return pi * (r * r) * h;
        }
        public override double ComplateArea()
        {
            return (2 * (pi * r / 2)) + 2 * pi * r * h;
        }
    }
}
