int n = int.Parse(Console.ReadLine());

double[][] planes = new double[n][];
double[][] radarData = new double[n][];
for (int i = 0; i < n; i++)
{
    string[] planeData = Console.ReadLine().Split(' ');
    planes[i] = new double[] { double.Parse(planeData[0]), double.Parse(planeData[1]) };
    radarData[i] = new double[] { double.Parse(planeData[2]), double.Parse(planeData[3]) };
}

int[] visibleCounts = new int[n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i != j)
        {
            double dx = planes[j][0] - planes[i][0];
            double dy = planes[j][1] - planes[i][1];

            double angle = Math.Abs(Math.Atan2(dy, dx) - Math.PI * radarData[i][0] / 180);
            double heightDiff = planes[j][1] - planes[i][1]; // Разница высот

            if (heightDiff > 0 && angle <= Math.PI * radarData[i][1] / 360) // текущий самолет сверху
            {
                visibleCounts[j]++;
            }
            else if (heightDiff < 0 && angle <= Math.PI * radarData[i][1] / 360) // текущий самолет снизу
            {
                visibleCounts[j]++;
            }
        }
    }
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine(visibleCounts[i]);
}



/*
 * 2
0 0 180 30
0 -5 0 30
*/







































/*
 * int n = int.Parse(Console.ReadLine()); // количество самолетов

double[][] planes = new double[n][];
double[][] radarData = new double[n][];
for (int i = 0; i < n; i++)
{
    string[] planeData = Console.ReadLine().Split(' ');
    planes[i] = new double[] { double.Parse(planeData[0]), double.Parse(planeData[1]) };
    radarData[i] = new double[] { double.Parse(planeData[2]), double.Parse(planeData[3]) };
}

int[] visibleCounts = new int[n]; // массив для хранения количества видимых радаров для каждого самолета

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i != j)
        {
            double dx = planes[j][0];
            double dy = planes[j][1];

            double angle = Math.Abs(Math.Atan2(dy, dx) - Math.PI * radarData[i][0] / 180); // магия
            Console.WriteLine("// Angle: " + angle);
            if (angle <= Math.PI * radarData[i][1] / 360)
            {
                visibleCounts[j]++;
            }
        }
    }
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine(visibleCounts[i]);
}
*/