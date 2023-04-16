using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double x1,x2,y1,y2;

Console.WriteLine("Введіть координати точки A:");
x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введіть координати точки B:");
x2 = Convert.ToDouble(Console.ReadLine());
y2 = Convert.ToDouble(Console.ReadLine());

double angleA = getAngle(x1, y1, 1, 0);
double angleB = getAngle(x2, y2, 1, 0);

string outText = angleA > angleB ? "OA" : "OB";

Console.WriteLine(outText);

double getAngle(double ax,double ay,double bx,double by) {
    double fi = (ax * bx + ay * by) / (Math.Sqrt(ax * ax + ay * ay) * Math.Sqrt(bx * bx + by * by));

    double angle = Math.Round(Math.Acos(fi) * 180/ Math.PI,3);
    return angle;
}