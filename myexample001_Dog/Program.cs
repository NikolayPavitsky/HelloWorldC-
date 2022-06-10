float dist = 10000;
float vd = 5, v1 = 1, v2 = 2;
float dist1 = 0, dist2 = 0, time = 0;
int number = 0;
while (dist > 10)
{
    number = number + 1;
    if((number / 2) == 0)
    {
        time = dist / (vd + v2);
    }    
    else
    {
        time = dist / (vd + v1);
    }
    dist1 = v1 * time;
    dist2 = v2 * time;
    dist = dist - dist1 - dist2;
}
Console.Write("Number=");
Console.WriteLine(number);
