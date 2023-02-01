namespace EvTapshiriqi_4_2
{
    public abstract class spacefigures
    {
        public spacefigures(double height, double radius)
        {
            this.h = height;
            this.r = radius;
            
        }

        protected double pi = Math.PI;      
        
        //protected double a;
        //protected double b;
        //protected double c;
        protected double h;
        protected double r;
        protected double l;

        public abstract double SeatArea();
        public abstract double ComplateArea();
        public abstract double Volume();


        public override string ToString()
        {
            return $@"## {this.GetType().Name}##
            Oturacagin sahesi: {this.SeatArea()}
            Hecmi : {this.Volume()}
            Umumi sethinin sahesi : {this.ComplateArea()}";
        }
    }
}
