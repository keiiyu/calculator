int ver1 = 10;
int ver2 = 6;

static int Penjumlahan(int var1, int var2)
{
    return var1 + var2;
}
static int Pengurangan(int var1, int var2)
{
    return var1 - var2;
}
static int Perkalian(int var1, int var2)
{
    return var1 * var2;
}
static int Pembagian(int var1, int var2)
{
    return var1 / var2;
}

Console.WriteLine("Penjumlahan: " + var1 + " + " + var2 + " = " + Penjumlahan(var1, var2));
Console.WriteLine("Pengurangan: " + var1 + " - " + var2 + " = " + Pengurangan(var1, var2);
Console.WriteLine("Perkalian: " + var1 + " * " + var2 + " = " + Perkalian(var1, var2));
Console.WriteLine("Pembagian: " + var1 + " / " + var2 + " = " + Pembagian(var1, var2));
