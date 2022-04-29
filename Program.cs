int method(int x, int n)
{
    
   if (n==0) return 1;
   if (n==1) return x;
  int a = method(x, n/2);
   
   if (n%2) return a* method(x, n-n/2);
   else return a*a;
}