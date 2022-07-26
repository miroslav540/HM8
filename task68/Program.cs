
int recursion(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    } 
    else if (n == 0 && m > 0)
    {
        return recursion(m - 1, 1);
    } 
    else
    {
        return recursion(m - 1, recursion(m, n - 1));
    }
}
void main(String[] args)
{
    Console.WriteLine(recursion(3, 2)); 
}


main(args);